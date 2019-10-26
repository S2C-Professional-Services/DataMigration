using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2CDataMigrationConsole.Services
{
    public static class LogService
    {
        public static void LogDetails(string content)
        {
            string exe = Process.GetCurrentProcess().MainModule.FileName;
            string path = Path.GetDirectoryName(exe);
            FileStream fs = new FileStream(path + @"\Logs" + @"\ServiceLog_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }
    }
}
