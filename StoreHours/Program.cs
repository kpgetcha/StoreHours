using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHours
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Store
    {
        public string StoreName { get; set; }
        // only reason to use dictionary is to make further validation. here the key will be the name of the day(ex Wednesday).
        // hence by putting this invariant they cannot add two store hours for same day.
        private Dictionary<string, StoreHours> hours = new Dictionary<string, StoreHours>();
        public bool AddHours(string dayName, DateTime startTime, DateTime endTime, bool isOpen)
        {
            bool flagSuccess = false;
            // adding logic to adding the days and verifying the data is in bound
            return flagSuccess;
        }

    }

    public class StoreHours
    {
        private DateTime _startTime;
        private DateTime _endTime;
        public string Day { get; set; }
        public bool IsOpen { get; set; }

        // good to use getters and setters as we can control who the private variables can be updated or accessed.
        // We can even put rules based on what start datetime and end datetime can be set based upon which day it is.
        public DateTime StartTime
        {
            get
            {
                return this._startTime;
            }
            set
            {
                this._startTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return this._endTime;
            }
            set
            {
                this._endTime = value;
            }
        }
    }
}
