using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx_simple_example.Models
{
    public class MyEvent2 : MyEvent
    {
        public int MyAge { get; set; }
        public MyEvent2(string name,int myage) : base(name)
        {
            MyAge = myage;

        }

        public override string ToString()
        {

            return $"Name:{Name}, MyAge:{MyAge} ";
        }
    }
}
