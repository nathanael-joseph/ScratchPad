using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BuilderDesignPattern
{
    // the Plan interface  
    public interface IRobotPlan
    {
        void SetRobotHead(string head);
        void SetRobotWeight(Double kg);
    }
}
