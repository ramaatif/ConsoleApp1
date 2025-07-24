using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SStopWatch
   { 
    public class StopWatch
    {
        private DateTime _StartTime;
        private DateTime _EndTime;
        private bool IsRunning;
        public TimeSpan Duration
        {
            get
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("StopWatch is still running , please stop it to get the duration");
                    
                }
                return _EndTime - _StartTime;
            }
        }
        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("StopWatch is already running , please stop it first");
            }

            _StartTime = DateTime.Now; //record the start time
            IsRunning = true; // set the stopwatch to running state
            Console.WriteLine("StopWatch is started");
        }
        public void Stop()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("StopWatch is not running , please start it first");
            }
            _EndTime = DateTime.Now;
            IsRunning = false; //set the stopwatch to not running state
            Console.WriteLine("StopWatch stopped");
        }
    }
}
