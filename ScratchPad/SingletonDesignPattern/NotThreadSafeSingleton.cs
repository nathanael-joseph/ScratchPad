using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.SingletonDesignPattern
{
    public class NotThreadSafeSingleton
    {
        private static NotThreadSafeSingleton _instance;
        private NotThreadSafeSingleton() { }

        public static NotThreadSafeSingleton Instance
        {
            get
            {
                // this conditional is not thread safe.
                if (_instance == null)
                {
                    _instance = new NotThreadSafeSingleton();
                }
                return _instance;
            }
        }
    }
}
