using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;

namespace MidiDomotica.Remote.AudioPlayer.SoundBoard
{
    internal class UrlAudioDownloader
    {
        private string _downloadsFolder;

        public UrlAudioDownloader(string downloadsFolder)
        {
            _downloadsFolder = downloadsFolder;
        }

        public string DownloadMp3FromUrl(string url)
        {
            if (url.Contains("www.youtube.com") || url.Contains("youtu.be"))
            {
                return DownloadMp3FromYouTube(url);
            }
            else
            {
                using (Stream ms = new MemoryStream())
                {
                    using (Stream stream = WebRequest.Create(url)
                        .GetResponse().GetResponseStream())
                    {
                        byte[] buffer = new byte[32768];
                        int read;
                        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            ms.Write(buffer, 0, read);
                        }
                    }

                    ms.Position = 0;

                    string mp3FileName = GenerateFileName(url);

                    FileStream fs = File.OpenWrite(mp3FileName);

                    ms.CopyTo(fs);

                    ms.Close();
                    fs.Close();

                    return mp3FileName;
                }
            }
        }

        private string GenerateFileName(string url)
        {
            Uri uri = new Uri(url);
            string mp3FileName = Path.Combine(_downloadsFolder, uri.Host + "_" + String.Join("-", uri.AbsolutePath.Split('/')));
            if (File.Exists(mp3FileName))
            {
                mp3FileName = RenameFileToNewest(mp3FileName);
            }

            return mp3FileName + ".mp3";
        }

        private string RenameFileToNewest(string path, int attempts = 0)
        {
            string newPath = path + "-File" + (attempts + 2).ToString();
            if (File.Exists(newPath))
            {
                return RenameFileToNewest(path, attempts++);
            }

            return newPath;
        }

        private string DownloadMp3FromYouTube(string url)
        {
            YouTube youtube = YouTube.Default;
            var video = youtube.GetVideo(url);

            string mp3InputFileName = Path.Combine(_downloadsFolder, $"{video.FullName}-pre.mp3");
            string mp3OutputFileName = Path.Combine(_downloadsFolder, $"{video.FullName}.mp3");

            if (!File.Exists(mp3InputFileName))
            {
                File.WriteAllBytes(mp3InputFileName, video.GetBytes());

                var inputFile = new MediaFile { Filename = mp3InputFileName };
                var outputFile = new MediaFile { Filename = mp3OutputFileName };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);

                    engine.Convert(inputFile, outputFile);
                }

                File.Delete(mp3InputFileName);
            }

            return mp3OutputFileName;
        }

        public static string GetYoutTubeVideoTitle(string url)
        {
            YouTube youtube = YouTube.Default;
            var video = youtube.GetVideo(url);

            return video.Title;
        }
    }
}
