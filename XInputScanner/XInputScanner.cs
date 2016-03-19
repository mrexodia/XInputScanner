using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YaraNET;

namespace XInputScanner
{
    public class XInputScanner
    {
        public delegate void LogDelegate(string text);
        private readonly LogDelegate _logger;
        private readonly YaraRules _yrRules;

        public XInputScanner(LogDelegate logger)
        {
            _logger = logger;
            List<YaraCompilationError> errors;
            try
            {
                _yrRules = Yara.Instance.CompileFromSource(Properties.Resources.yaraRules, null, false, null, out errors);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Yara exception!");
            }
        }

        public void ScanFile(string filePath)
        {
            if (filePath.Contains("xinput") || filePath.Contains("x360ce")) //skip x360ce related files
                return;
            try
            {
                List<YaraMatch> matches;
                try
                {
                    matches = _yrRules.MatchFile(filePath, null, false, 0);
                }
                catch (Exception e)
                {
                    log("Yara exception: {0}", e.Message);
                    return;
                }
                foreach (var match in matches)
                    log("{0}: {1}", Path.GetFileName(filePath), match.Rule.Name + ".dll");
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
