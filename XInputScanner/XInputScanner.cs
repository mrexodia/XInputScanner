using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace XInputScanner
{
    public class XInputScanner
    {
        public delegate void LogDelegate(string text);
        private readonly LogDelegate _logger;

        public XInputScanner(LogDelegate logger)
        {
            _logger = logger;
        }

        public void ScanFile(string filePath)
        {
            try
            {
                var data = File.ReadAllBytes(filePath);
                log("Scanning {0}", Path.GetFileName(filePath));
            }
            catch
            {
            }
        }

        public void ScanFiles(IEnumerable<string> filePaths, bool recursive)
        {
            Parallel.ForEach(filePaths, (filePath) =>
            {
                var attributes = File.GetAttributes(filePath);
                if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    ScanDirectory(filePath, recursive);
                else
                    ScanFile(filePath);
            });
        }

        public void ScanDirectory(string directoryPath, bool recursive)
        {
            log("Scanning {0}", directoryPath);
            var option = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            Parallel.ForEach(Directory.GetFiles(directoryPath, "*.exe", option), ScanFile);
            Parallel.ForEach(Directory.GetFiles(directoryPath, "*.dll", option), ScanFile);
        }

        private void log(string text, params object[] args)
        {
            var message = args.Length == 0 ? text : string.Format(text, args);
            if (_logger != null)
                _logger(message + "\n");
            else
                Console.WriteLine(message);
        }
    }
}
