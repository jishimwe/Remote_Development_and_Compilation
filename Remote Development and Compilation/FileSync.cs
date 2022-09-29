using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Development_and_Compilation
{
    internal class FileSync
    {
        public static string OpenFile()
        {
            string path = @"C:\Users\test\Documents\PlayMusic\app\src\main\java\com\ishim\playmusic\MainActivity.kt";

            using (FileStream fs = File.OpenRead(path))
            {
                byte[] buffer = new byte[4096];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                    Debug.WriteLine(temp.GetString(buffer));
                }
            }
            return path;
        }
    }
}
