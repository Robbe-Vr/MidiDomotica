using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace MidiDomotica.Core.MidiConnection
{
    internal class ProcessEvents
    {
        private List<string> processNames = new List<string>();
        private List<string> runningProcesses = new List<string>();

        private ManagementEventWatcher watcher;

        public ProcessEvents(string[] processes)
        {
            if (processes != null && processes.Length > 0)
            {
                processNames.AddRange(processes);

                SubscribeToEvents();
            }
        }

        private void SubscribeToEvents()
        {
            foreach (string processName in processNames)
            {
                string pol = "2";
                string queryString = "SELECT * FROM __InstanceOperationEvent WITHIN " + pol + " WHERE TargetInstance ISA 'Win32_Process' AND ";

                queryString += "TargetInstance.Name = '" + processName + "'";

                EventQuery query = new EventQuery(queryString);

                ManagementScope scope = new ManagementScope(@"\\.\root\CIMV2");

                watcher = new ManagementEventWatcher(scope, query);

                watcher.EventArrived += (sender, e) =>
                {
                    if (e.NewEvent.ClassPath.ClassName == "__InstanceCreationEvent" || e.NewEvent.ClassPath.ClassName == "__InstanceModificationEvent")
                    {
                        if (!runningProcesses.Contains(processName))
                        {
                            runningProcesses.Add(processName);

                            if (runningProcesses.Count == 1)
                            {
                                processStarted.Invoke(this, new EventArgs());
                            }
                        }
                    }
                    else if (e.NewEvent.ClassPath.ClassName == "__InstanceDeletionEvent")
                    {
                        runningProcesses.Remove(processName);

                        if (runningProcesses.Count == 0)
                        {
                            processEnded.Invoke(this, new EventArgs());
                        }
                    }
                };
                watcher.Start();
            }
        }

        public void Dispose()
        {
            if (watcher != null)
            {
                watcher.Stop();
                watcher.Dispose();
                watcher = null;
            }

            if (processNames != null)
            {
                processNames.Clear();
                processNames = null;
            }
        }

        public void ResetProcesses(string[] processes)
        {
            processNames.AddRange(processes);

            SubscribeToEvents();
        }

        public event EventHandler processStarted;
        public event EventHandler processEnded;
    }
}
