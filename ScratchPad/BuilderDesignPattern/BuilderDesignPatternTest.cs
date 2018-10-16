using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BuilderDesignPattern
{
    public static class BuilderDesignPatternTest
    {
        public static void Test()
        {
            GoldRobotBuilder builder = new GoldRobotBuilder();
            RobotEngineer engineer = new RobotEngineer(builder);
            engineer.MakeRobot();
            Robot robot = engineer.GetRobot();

            Console.WriteLine("[Robot, Head = {0}, Weight = {1}Kg ", robot.Head, robot.Weight);
            
        }
    }
}
