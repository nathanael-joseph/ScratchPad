using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BuilderDesignPattern
{
    public interface IRobotBuilder
    {
        void BuildRobotHead();
        void BuildRobotWeight();
        Robot GetRobot();
    }
}
