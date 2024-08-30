using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04.Third_Project
{
    internal class Duration
    {
        public int Hours {  get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration (int totalseconds)
        {
            Hours = totalseconds / 3600;
            totalseconds = totalseconds % 3600;
            Minutes = totalseconds / 60;
            Seconds = totalseconds / 60;

        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration () { }

        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }

            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration d = (Duration)obj;
            return (Hours == d.Hours) && (Minutes == d.Minutes) && (Seconds == d.Seconds);
        }

        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }

        public override string ToString()
        {
            return $"Hours : {Hours} , Minutes : {Minutes} , Seconds : {Seconds}";
        }

        public static Duration operator +(Duration left , Duration right)
        {
            return new Duration()
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds
            };

        }

        public static Duration operator +(Duration left, int toatalSecond)
        {
            int totalS = toatalSecond;
            int Hour = totalS / 3600;
            totalS %= 3600;
            int Minute = totalS / 60;
            int Second = totalS / 60;
            return new Duration()
            {
                Hours = left.Hours + Hour,
                Minutes = left.Minutes + Minute,
                Seconds = left.Seconds + Second
            };

        }

        public static Duration operator +(int totalSecond, Duration right)
        {
            int totalS = totalSecond;
            int Hour = totalS / 3600;
            totalS %= 3600;
            int Minute = totalS / 60;
            int Second = totalS / 60;
            return new Duration()
            {
                Hours = right.Hours + Hour,
                Minutes = right.Minutes + Minute,
                Seconds = right.Seconds + Second
            };

        }

        public static Duration operator -(Duration left, Duration right)
        {
            if (left.Hours < right.Hours || left.Minutes < right.Minutes || left.Seconds < right.Seconds)
            {
                Console.WriteLine("There Is No Time With Negative Values");
                return new Duration()
                {
                    Hours = 0,
                    Minutes = 0,
                    Seconds = 0
                };
            }
            else
            {
                return new Duration()
                {

                    Hours = left.Hours - right.Hours,
                    Minutes = left.Minutes - right.Minutes,
                    Seconds = left.Seconds - right.Seconds
                };

            }
        }

        public static Duration operator ++(Duration Minutes)
        {
            return new Duration()
            {
                 Hours = Minutes.Hours,
                 Minutes = Minutes.Minutes + 1,
                 Seconds = Minutes.Seconds
            };
        }

        public static Duration operator --(Duration Minutes)
        {
            return new Duration()
            {
                Hours = Minutes.Hours,
                Minutes = Minutes.Minutes - 1,
                Seconds = Minutes.Seconds
            };
        }


        public static bool operator >(Duration left , Duration right)
        {
            if(left.Hours > right.Hours)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours < right.Hours)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool operator <= (Duration left, Duration right)
        {
            if (left.Hours <= right.Hours)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hours >= right.Hours)
            {
                return true;
            }
            else
            {
                return false;
            }

        }








        public static bool operator true(Duration d)
        {
            if( d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator false(Duration d)
        {
             if (d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(duration.Hours, duration.Minutes, duration.Seconds);
        }

    }
}
