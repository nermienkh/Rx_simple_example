using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx_simple_example.Models
{
  public  class MyEvent1 : MyEvent
    {
        public int Mynumber { get; set; }
        public MyEvent1(string name, int mynumber) :base (name)
        {
            Mynumber = mynumber;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Mynumber:{Mynumber} ";
        }
    }
}
