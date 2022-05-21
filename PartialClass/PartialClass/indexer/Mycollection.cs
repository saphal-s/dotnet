using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass.indexer
{
    internal class Mycollection
    {
        //private string[] _Collection = new string[10];
        private int One = 1;
        private int Two = 2;
        private int Three = 3;
        private int Four = 4;
 
        //public string this[string index]
         public int this[string index]
        {
        //   get
        //   {
        //       if(index > 9)
        //       {
        //           Console.WriteLine("invalid index");
        //           return "";
        //       }
        //       return _Collection[index];
        //   }
        //   set {
        //       if (index > 9)
        //       {
        //           Console.WriteLine("invalid index");
        //       }
        //       _Collection[index] = value;
        //   }
        get
            {
                if(index == "One")
                    return One;
                if (index == "Two")
                    return Two;
                if (index == "Three")
                    return Three;
                if (index == "Four")
                    return Four;
                else return 0;
                
            }
        }
    }
}
