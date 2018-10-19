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
            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
                Console.WriteLine("---[Folder Name] :" + Path.GetFileName(folder));
            }
        }

        // Check to see whether a path is in a parent directory.
        public static bool IsChildOf(string child, string parent)
        {
            try
            {
                return child.Substring(0, parent.Length) == parent;
            }
            catch(Exception e)
            {              
                e.Message.P();
                return false;
            }
        }


        public static void TestIsChildOf()
        {
            string parent = @"D:\College2017\SmartQA\SRC\SmartQA\SmartQA.WebApplication\App_Data\1_Talentsoft\Yebgui1";
            string child1 = @"D:\College2017\SmartQA\SRC\SmartQA\SmartQA.WebApplication\App_Data\1_Talentsoft\Yebgui1\file01 (2).txt";
            string child2 = @"D:\College2017\SmartQA\SRC\SmartQA\SmartQA.WebApplication\App_Data\1_Talentsoft\Yebgui1\folder001";
            string child3 = "";

            IsChildOf(child1, parent).ToString().P();
            IsChildOf(child2, parent).ToString().P();
            IsChildOf(child3, parent).ToString().P();
        }
    }

}
