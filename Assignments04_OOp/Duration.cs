using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments04_OOp
{
    internal class Duration
    {
        #region Attributes
        private int hours;
        private int minutes;
        private int seconds;
        #endregion

        #region Property
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructor
        public Duration(int _hours, int _minutes, int _seconds)
        {
            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }

        public Duration(int totalSeconds)
        {
            hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;
        }
        #endregion

        #region Part02 1.
        //public override string ToString()
        //{
        //    return $"Hours:{hours}, Minutes{minutes}, Seconds{seconds}";
        //} 
        #endregion

        #region  Methods
        public override string ToString()
        {
            string result = null;
            if (hours > 0) result += $"Hours: {hours}, ";

            if (minutes > 0 || hours > 0) result += $"Minutes: {minutes}, ";

            result += (result == "" ? "" : ", ") + $"Seconds: {seconds}";

            return result;
        }
        #endregion

        #region Part02 5. Operator Overloadding
        //public static Duration operator +(Duration d1, Duration d2)
        //{
        //    return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        //}


        //public static Duration operator +(Duration d1, int seconds)
        //{
        //    return new Duration(d1.TotalSeconds() + seconds);
        //}


        //public static Duration operator +(int seconds, Duration d1)
        //{
        //    return new Duration(seconds + d1.TotalSeconds());
        //}

        //public static Duration operator ++(Duration d)
        //{
        //    return new Duration(d.TotalSeconds() + 60);
        //}


        //public static Duration operator --(Duration d)
        //{
        //    return new Duration(d.TotalSeconds() - 60);
        //}


        //public static Duration operator -(Duration d1, Duration d2)
        //{
        //    return new Duration(d1.TotalSeconds() - d2.TotalSeconds());
        //}


        //public static bool operator > (Duration d1, Duration d2)
        //{
        //    return d1.TotalSeconds() > d2.TotalSeconds();
        //}

        //public static bool operator <(Duration d1, Duration d2)
        //{
        //    return d1.TotalSeconds() < d2.TotalSeconds();
        //}

        //public static bool operator <=(Duration d1, Duration d2)
        //{
        //    return d1.TotalSeconds() <= d2.TotalSeconds();
        //}

        //public static bool operator >=(Duration d1, Duration d2)
        //{
        //    return d1.TotalSeconds() >= d2.TotalSeconds();
        //}

        //public static implicit operator bool(Duration d)
        //{
        //    return d.TotalSeconds() > 0;
        //}


        //public static explicit operator DateTime(Duration d)
        //{
        //    return new DateTime(1, 1, 1, d.hours, d.minutes, d.seconds);
        //}
        //public int TotalSeconds()
        //{
        //    return hours * 3600 + minutes * 60 + seconds;
        //} 
        #endregion

    } 
}

