using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.BuilderDesignPattern;

namespace ScratchPad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the Builder Design Pattern.
            BuilderDesignPatternTest.Test();

            // Testing DirectoryPractice code.
            DirectoryPractice.DirectoryPracticeTest.PrintDirectoryContent();

            DirectoryPractice.DirectoryPracticeTest.TestIsChildOf();

            Console.ReadKey();
        }
    }

}
