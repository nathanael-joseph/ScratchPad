using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScratchPad.DirectoryPractice
{
    public static class DirectoryPracticeTest
    {
        public static void PrintDirectoryContent()
        {
            string myDir = @"C:\Users\natha\Desktop";
            string[] files = Directory.GetFiles(myDir);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine("### File Name : " + Path.GetFileName(file));
            }
            Console.WriteLine("---------------------------------------------------------------");
            string[] folders = Directory.GetDirectories(myDir);
            foreach (string folder in folders )
            {
                Console.WriteLine(folder);
                Console.WriteLine("---[Folder Name] :" + Path.GetFileName(folder));
            }
        }
    }

}
