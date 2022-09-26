using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Development_and_Compilation
{
    internal class FileSync
    {
        public static void Main()
        {
            string path = @"C:\Users\ishim\source\repos\Remote Development and Compilation\Test Files\TFE23-254-Raincode_DistributedDev.txt";

            using (FileStream fs = File.OpenRead(path))
            {
                byte[] buffer = new byte[4096];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(buffer));
                }
            }
        }
    }
}
