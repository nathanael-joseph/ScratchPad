﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.SingletonDesignPattern
{
    public class SimpleThreadSafeSingleton
    {
        private static SimpleThreadSafeSingleton _instance;
        private static readonly object padlock = new object();
        private SimpleThreadSafeSingleton() { }

        public static SimpleThreadSafeSingleton Instance
        {
            get
            {
                // this is thread safe, but the lock is pessimistic, it is always called, even when _instance exists.
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new SimpleThreadSafeSingleton();
                    }
                    return _instance;
                }
            }
        }

    }
}
