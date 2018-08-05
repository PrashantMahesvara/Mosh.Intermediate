using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercise1
{
    public class Stopwatch
    {
        public static DateTime Now { get; set; }

        public static DateTime Start(DateTime time)
        {
            var timerStart = time;

            var newTime = timerStart;

            return timerStart;
        }

        public static DateTime Stop(DateTime time)
        {
            var timerStop = DateTime.Now;

            var test = Start(time);

            return timerStop;
        }
            
        public void Duration (DateTime time)
        {
            var difference = Start(time) - Stop(time);

            return;
        }
    }
}
