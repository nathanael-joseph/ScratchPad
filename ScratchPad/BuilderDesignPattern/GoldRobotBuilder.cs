using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BuilderDesignPattern
{
    public class GoldRobotBuilder : IRobotBuilder
    {
        public Robot Robot { get; private set; }
        public GoldRobotBuilder()
        {
            Robot = new Robot();
        }
        public void BuildRobotHead()
        {
            Robot.SetRobotHead("Golden Head");
        }

        public void BuildRobotWeight()
        {
            Robot.SetRobotWeight(24.24);
        }

        public Robot GetRobot()
        {
            return Robot;
        }
    }
}
