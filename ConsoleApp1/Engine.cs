using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Engine // Engine class has properties EngineType and methods StartEngine and StopEngine
    {
        #region
        public string EngineType { get; set; }
        public Engine(string engineType)
        {
            EngineType = engineType;
        }
        #endregion

        #region
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
        #endregion
        #region
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
        #endregion
    }
}
