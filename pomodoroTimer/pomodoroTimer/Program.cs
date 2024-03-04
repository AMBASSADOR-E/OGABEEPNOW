using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoroTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pomodoro Timer - press any key to start");
            Console.ReadKey(); // wait for user input to start
            while (true)
            {
                Console.Clear(); // clear console screen
                Console.WriteLine("Work for 25 minutes"); // display work message
                int
                    remainingTime = 25 * 60; // calculate remaining time in seconds
                while (remainingTime > 0)
                {
                    Console.SetCursorPosition(0, 1); // move cursor to second line
                    Console.Write(String.Format("Time remaiing: {0:D2}: {1:D2}",
                        remainingTime / 60, remainingTime % 60)); // display remaining time
                   // ThreadStaticAttribute.Sleep(1000); // wait one second
                    remainingTime--; // count down remaining time
                }
                Console.Beep(); // beep when work time is up
                Console.Clear(); // clear console screen
                Console.WriteLine("Rest for five minutes"); // display rest message
                remainingTime = 5 * 60; // calculate remaining time in seconds
                while
                    (remainingTime > 0)
                {
                    Console.SetCursorPosition(0, 1); // move cursor to second line
                    Console.Write(String.Format("Time remaining: {0:D2}: {1:D2}",
                        remainingTime / 60, remainingTime % 60));// display remaining time

                   // ThreadStaticAttribute.Sleep(1000); // wait one second
                    remainingTime--; // count down remaining time
                }
                Console.Beep(); // beep when rest time is up
            }
        }
    }
}
