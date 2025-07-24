

namespace SStopWatch
{
  
    using System.Collections.Generic;

    class Program
    {

        #region//StopWatch
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in StopWatch testing ");
            var Stopwatch = new StopWatch();
            try
            {

                Stopwatch.Start();
                Console.WriteLine("Stopwatch start counting");
                Thread.Sleep(2000);
                Stopwatch.Stop();
                Console.WriteLine("Stopwatch stopped");
                Console.WriteLine($"Duration in the first time: {Stopwatch.Duration.TotalSeconds:F2}");

            }
            catch (InvalidOperationException ex)
            { Console.WriteLine($"Error Occured : {ex.Message}"); }
            catch (Exception ex)
            { Console.WriteLine($" Generic Error Occured :{ex.Message}"); }
            try
            {
                Stopwatch.Start();
                Console.WriteLine("StopWatch started successfully");
                Stopwatch.Start();

            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine($"The Error has been catched{ex.Message}");
                Stopwatch.Stop();
                Console.WriteLine("stopwatch stopped after error");
            }
            catch (Exception ex) { Console.WriteLine($"Generic Error Occured : {ex.Message}"); }
            try
            {
                //  لو حد حاول يوقف الساعه وهي اصلا مش شغاله
                var MyStopwatch = new StopWatch();
                MyStopwatch.Stop();

            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine($"The Error has been catched {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Generic Error Occured : {ex.Message}");
            }
            Console.WriteLine("\n Multiple usage testing");
            Console.WriteLine("\n Second Time: start and stop on the same object");
            try
            {
                Stopwatch.Start();
                Thread.Sleep(1500);
                Stopwatch.Stop();
                Console.WriteLine("StopWatch stopped again in the second time");
                Console.WriteLine($"Duration in the second time: {Stopwatch.Duration.TotalSeconds:F2}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error has been catched {ex.Message}");
            }
            catch (Exception ex)
            { Console.WriteLine($"Generic Error Occured : {ex.Message}"); }

            Console.WriteLine("\n Third Time: start and stop on the same object");
            try
            {
                Stopwatch.Start();
                Thread.Sleep(500);
                Stopwatch.Stop();
                Console.WriteLine("StopWatch stopped in the third time");
                Console.WriteLine($"Duration in the third time: {Stopwatch.Duration.TotalSeconds:F2}");
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine($"The error has been catched {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Generic Error Occured : {ex.Message}");
            }
            Console.WriteLine("Testing Has been ended");
            Console.ReadKey();
            #endregion

        }

    }




}


