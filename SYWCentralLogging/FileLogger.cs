using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYWCentralLogging
{
    internal class FileLogger
    {
        private string CentralLoggingLocation { get { return (LoggingInfo.InDockerContainer ? "app" : "D:") + "\\CentralLogging"; } }

        internal void LogToLocation(string location, string message)
        {
            if (!String.IsNullOrEmpty(LoggingInfo.AdditionalLogFolderLocation))
            {
                string addFullPath = Path.Combine(LoggingInfo.AdditionalLogFolderLocation, $"Log-{DateTime.Today:yyyy-MM-dd}.txt");

                using (StreamWriter addWriter = File.Exists(addFullPath) ? new StreamWriter(addFullPath) : File.AppendText(addFullPath))
                {
                    addWriter.WriteLine(message);
                }
            }

            string logFolder = Path.Combine(CentralLoggingLocation, location);
            if (!Directory.Exists(logFolder))
                Directory.CreateDirectory(logFolder);

            string fullPath = Path.Combine(logFolder, $"Log-{DateTime.Today:yyyy-MM-dd}.txt");

            using (StreamWriter writer = File.Exists(fullPath) ? new StreamWriter(fullPath) : File.AppendText(fullPath))
            {
                writer.WriteLine(message);
            }
        }
    }
}
