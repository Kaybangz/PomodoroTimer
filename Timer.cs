using System;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace Pomodoro_timer
{
    public class PomoTimer
    {

        Stopwatch stopwatch = new Stopwatch();

        private int workTime;
        private int restTime;


     

        public PomoTimer(int workTime, int restTime)
        {
            this.workTime = workTime;
            this.restTime = restTime;
        }


        public void startWorkTime()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var workTimeStart = DateTime.Now.ToString("HH:mm");


            Thread.Sleep(this.workTime);


            stopWatch.Stop();
            var workTimeEnd = DateTime.Now.ToString("HH:mm");


            Console.Beep();

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);


            Console.WriteLine($"\nWork time lasted for {elapsedTime} \n{workTimeStart} - {workTimeEnd}");
        }



        public void startRestTime()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var restTimeStart = DateTime.Now.ToString("HH:mm");


            Thread.Sleep(this.restTime);


            stopWatch.Stop();
            var restTimeEnd = DateTime.Now.ToString("HH:mm");


            Console.Beep();


            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);


            Console.WriteLine($"\nRest time lasted for {elapsedTime} \n{restTimeStart} - {restTimeEnd}");
        }


    }
}
