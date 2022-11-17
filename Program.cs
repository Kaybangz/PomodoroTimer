using System;
using System.Diagnostics;
using System.Timers;


namespace Pomodoro_timer
{
    internal class Program
    {
        public static double ConvertMinutesToMilliseconds(int minutes)
        {
            return TimeSpan.FromMinutes(minutes).TotalMilliseconds;
        }

        static void Main(string[] args)
        {

            while (true)
            {
                //Prompt for the user to enter work and rest time
                Console.WriteLine("Enter work time in minutes: ");
                int workTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Work time saved, Great work buddy!");
                

                Console.WriteLine("\nEnter rest time in minutes: ");
                int restTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rest time saved...");


                //Take user's input and convert to milliseconds using the ConvertToMilliseconds method
                int convertWorkTimeToMs = (int)ConvertMinutesToMilliseconds(workTime);
                int convertRestTimeToMs = (int)ConvertMinutesToMilliseconds(restTime);


                //Create an instance of the PomoTimer class
                PomoTimer timer = new PomoTimer(convertWorkTimeToMs, convertRestTimeToMs);



                //Prompt for the user to start timer
                Console.WriteLine("\nDo you want to start the timer(y/n): ");

                string? startTimer = Console.ReadLine();


                if(startTimer == "y")
                {
                    Console.WriteLine("\nWork timer is running...");
                    timer.startWorkTime();

                    Console.WriteLine("\nRest timer is running...");
                    timer.startRestTime();
                }

                else if(startTimer == "n")
                {
                    continue;
                }

                else if(startTimer != "n" && startTimer != "y")
               {
                    Console.WriteLine("\nPlease enter a valid input, y for yes and n for no");
                    continue;
                }


                //Prompt for user to continue using the timer
                Console.WriteLine("\nWould you like to keep using the timer(y/n): ");

                string? continueUsingTimer = Console.ReadLine();

                if(continueUsingTimer == "y")
                {
                    continue;
                }
                else if(continueUsingTimer == "n")
                {
                    break;
                }
                else if (continueUsingTimer != "n" && continueUsingTimer != "y")
                {
                    Console.WriteLine("\nPlease enter a valid input next time, y for yes and n for no");
                    break;
                }

            }
        }
    }
}