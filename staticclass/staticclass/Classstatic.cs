using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticclass
{
    public static class Time
    {
        private static DateTime _Current;
        static Time()
        {
            _Current = DateTime.Now;
        }
    }
}
