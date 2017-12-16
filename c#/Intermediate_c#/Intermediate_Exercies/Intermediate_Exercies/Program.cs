using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercise 1: Design a Stopwatch

Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.

We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row 
(because that may overwrite the initial start time). 
So the class should throw an InvalidOperationException if its started twice.

 */
namespace Intermediate_Exercies
{
    public class Stopwatch
    {
        public TimeSpan clock = new TimeSpan();
        public TimeSpan second = new TimeSpan(0,0,1);
        public bool watchStopped = true;

        public void Start()
        {
            watchStopped = false;
            while(watchStopped == false)
            {
                clock = clock.Add(second);
                Console.WriteLine(clock);
                while (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        watchStopped = true;
                    }
                }
            }
        }
        public void Stop()
        {
            watchStopped = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            


            while (!Console.KeyAvailable)
            {
               if(Console.ReadKey().Key == ConsoleKey.A)
                {
                    stopWatch.Start();
                }
               


            }

            
        }
    }
}



/*
 * Console.ReadKey().Key == ConsoleKey.S
 I like this function 
  public void Start()
    {      
        do
        {
            while(!Console.KeyAvailable)
            {
                Console.WriteLine(duration = duration.Add(second));
            }
                
        } while (Console.ReadKey().Key != ConsoleKey.S);
    }
 */
