using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BuilderDesignPattern
{   
    // Also called a Director.
    public class RobotEngineer
    {
        private IRobotBuilder _robotBuilder;

        public RobotEngineer(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }

        public void MakeRobot()
        {
            _robotBuilder.BuildRobotHead();
            _robotBuilder.BuildRobotWeight();
        }

        public Robot GetRobot()
        {
            return _robotBuilder.GetRobot();
        }

    }
}
