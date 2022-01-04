using System;
using System.Diagnostics;

namespace SYWCentralLogging
{
    public static class Logger
    {
        /// <summary>
        /// Set to true if this application is run isnide a docker container, it will adjust the log file location from the windows drive location to the /app folder. DO NOT FORGET TO LINK THE VOLUME!
        /// </summary>
        public static bool InDockerContainer { get { return LoggingInfo.InDockerContainer; } set { LoggingInfo.InDockerContainer = value; } }
        /// <summary>
        /// Set to true if you want to log to files only, is false by default. Will log to console using Trace.WriteLine and Console.WriteLine if false.
        /// </summary>
        public static bool FileOnlyLogging { get { return LoggingInfo.FileOnlyLogging; } set { LoggingInfo.FileOnlyLogging = value; } }

        /// <summary>
        /// If you want the Logger to save logfiles to another folder besides the central loggin location aswell, provide a valid folder location here.
        /// </summary>
        public static string AdditionalLogFolderLocation { get { return LoggingInfo.AdditionalLogFolderLocation; } set { LoggingInfo.AdditionalLogFolderLocation = value; } }

        private static readonly FileLogger _fileLogger = new FileLogger();

        public static string SourceAppName { get; set; }

        public static void LogObj(object obj, string includedMessage = null, string logUnderOtherName = null)
        {
            Log(String.IsNullOrEmpty(includedMessage) ?
                System.Text.Json.JsonSerializer.Serialize(obj) :
                $"{includedMessage}.\r\nIncluded Object:\r\n{System.Text.Json.JsonSerializer.Serialize(obj)}\r\n",
                logUnderOtherName);
        }

        public static void LogNewLine(string logUnderOtherName = null)
        {
            if (String.IsNullOrEmpty(logUnderOtherName ?? SourceAppName))
            {
                throw new MissingFieldException("Please provide a source application name for the Logger to separate the application logs on the central logging location.\nEnter this name in the public string property named: 'SourceAppName'.");
            }

            string logMsg = "\r\n";

            _fileLogger.LogToLocation(logUnderOtherName ?? SourceAppName, logMsg);

            if (!FileOnlyLogging)
            {
                Trace.WriteLine(logMsg);
                Console.WriteLine(logMsg);
            }
        }

        public static void Log(string message, string logUnderOtherName = null)
        {
            if (String.IsNullOrEmpty(logUnderOtherName ?? SourceAppName))
            {
                throw new MissingFieldException("Please provide a source application name for the Logger to separate the application logs on the central logging location.\nEnter this name in the public string property named: 'SourceAppName'.");
            }

            string logMsg = $"[[{logUnderOtherName ?? SourceAppName}]] at [{DateTime.Now:HH:mm:ss:ff t K}] {message}";

            _fileLogger.LogToLocation(logUnderOtherName ?? SourceAppName, logMsg);

            if (!FileOnlyLogging)
            {
                Trace.WriteLine(logMsg);
                Console.WriteLine(logMsg);
            }
        }
    }
}
