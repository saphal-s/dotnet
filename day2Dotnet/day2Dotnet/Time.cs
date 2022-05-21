using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Dotnet
{
    public class Time
    {
        private int _seconds; //field
        public int Seconds //properties
        {
            get { return _seconds; }//accessors
            set { _seconds = value; }//accessors
        }
        public decimal Minutes
        {
            get { return Seconds / 60; }
            set { Seconds = (int)value * 60; }

        }
        public decimal Hours
        {
            get { return Minutes / 60; }
            set { Minutes = value * 60; }

        }
    }
}
