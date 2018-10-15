using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BuilderDesignPattern
{
    public class Robot : IRobotPlan
    {
        public string Head { get; private set; }
        public double Weight { get; private set; }

        public void SetRobotHead(string head)
        {
            Head = head;
        }

        public void SetRobotWeight(double kg)
        {
            Weight = kg;
        }
    }
}
