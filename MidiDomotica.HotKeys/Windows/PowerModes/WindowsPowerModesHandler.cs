using Microsoft.Win32;
using MidiDomotica.Exchange.ActionObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Windows.PowerModes
{
    public class WindowsPowerModesHandler
    {
        public IEnumerable<WindowsPowerMode> WindowsPowerModes { get; private set; }

        public WindowsPowerModesHandler()
        {
            GetPowerModes();
        }

        private void GetPowerModes()
        {
            Task.Run(() =>
            {
                List<WindowsPowerMode> powerModes = new List<WindowsPowerMode>();

                using (Process command = new Process())
                {
                    command.StartInfo.FileName = "cmd.exe";
                    command.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    command.StartInfo.CreateNoWindow = true;
                    command.StartInfo.UseShellExecute = false;

                    command.StartInfo.RedirectStandardInput = true;
                    command.StartInfo.RedirectStandardOutput = true;
                    command.StartInfo.RedirectStandardError = true;

                    command.StartInfo.WorkingDirectory = @"C:\";

                    command.Start();

                    command.StandardInput.WriteLine("powercfg -L" + command.StandardInput.NewLine);
                    command.StandardInput.Flush();
                    command.StandardInput.Close();

                    Thread.Sleep(100);

                    StringBuilder strOuput = new StringBuilder();
                    while (command.StandardOutput.Peek() > -1)
                    {
                        string line = command.StandardOutput.ReadLine();
                        if (line.StartsWith("Power Scheme GUID"))
                        {
                            strOuput.AppendLine(line);
                        }
                    }

                    StringBuilder strError = new StringBuilder();
                    while (command.StandardError.Peek() > -1)
                    {
                        string line = command.StandardError.ReadLine();
                        strError.AppendLine(line);
                    }

                    command.WaitForExit();
                    command.Close();

                    string output = strOuput.ToString();
                    string error = strError.ToString();

                    if (output.Length > 0)
                    {
                        Trace.WriteLine("\n-------Power Modes----------\n");
                        Trace.WriteLine(output);

                        string[] powerSchemeInfos = output.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string powerSchemeInfo in powerSchemeInfos)
                        {
                            var infopoints = powerSchemeInfo.Split(':')[1].Split('(');

                            powerModes.Add(new WindowsPowerMode()
                            {
                                Guid = infopoints[0].Trim(),
                                Name = infopoints[1].Split(')')[0],
                            });
                        }
                    }
                    else
                    {
                        Trace.WriteLine($"Error retrieving powermodes: {error}\n");
                    }
                }

                WindowsPowerModes = powerModes;
            }).Wait();
        }

        public void SetPowerMode(WindowsPowerMode powerMode)
        {
            Process command = new Process();

            command.StartInfo.FileName = "cmd.exe";
            command.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            command.StartInfo.CreateNoWindow = false;
            command.StartInfo.UseShellExecute = false;

            command.StartInfo.RedirectStandardInput = true;
            command.StartInfo.RedirectStandardOutput = true;
            command.StartInfo.RedirectStandardError = true;

            command.StartInfo.WorkingDirectory = @"C:\";

            command.Start();

            command.StandardInput.WriteLine($"powercfg -setactive {powerMode.Guid}" + command.StandardInput.NewLine);
            command.StandardInput.Flush();
            command.StandardInput.Close();

            Thread.Sleep(500);

            StringBuilder strOutput = new StringBuilder();
            while (command.StandardOutput.Peek() > -1)
            {
                string line = command.StandardOutput.ReadLine();
                if (!line.StartsWith("Microsoft Windows [Version") &&
                    !line.StartsWith("(c) Microsoft Corporation. All rights reserved.") &&
                    !line.StartsWith("C:\\>"))
                {
                    strOutput.AppendLine(line);
                }
            }

            StringBuilder strError = new StringBuilder();
            while (command.StandardError.Peek() > -1)
            {
                string line = command.StandardError.ReadLine();
                strError.AppendLine(line);
            }

            command.WaitForExit();
            command.Close();

            string output = strOutput.ToString();
            string error = strError.ToString();

            if (output.Length > 0 && output.StartsWith("\r\n\r\n"))
            {
                return;
            }

            string errStr = strError.Length > 0 ? $"\nError: {error}" : "";
            throw new ArgumentException($"Error occurred!\nOutput: {output}{errStr}");
        }
    }
}
