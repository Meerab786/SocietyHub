using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final
{
    public class Logger
    {
        private static string logPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "error_log.txt");

        public static void LogError(string source, Exception ex)
        {
            try
            {
                string entry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{source}] {ex.Message}{Environment.NewLine}";
                File.AppendAllText(logPath, entry);
            }
            catch { }
        }
    }
}
