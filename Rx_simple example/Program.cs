using Rx_simple_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rx_simple_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of different events
            List<MyEvent> events = new List<MyEvent>() { new MyEvent1("MyEvent1", 232565), new MyEvent2("MyEvent2", 25) };
            //transform list to observable 
            var myObservable = events.ToObservable();
            //create subscriber that observes changes in the observable 
            myObservable.Subscribe(anyEvent =>
            {

                switch (anyEvent)
                {
                    case MyEvent1 myEvent1:
                        {
                            Console.WriteLine($"I am subscriber1  MyEvent1 has arrived, {myEvent1.ToString()}");
                            Console.WriteLine();
                            break;
                        }
                    case MyEvent2 myEvent2:
                        {
                            Console.WriteLine($"I am subscriber1  MyEvent2 has arrived, {myEvent2.ToString()}");
                            Console.WriteLine();
                            break;
                        }
                    default:
                        break;
                }

            });
            //create subscriber that observes changes in the observable 
            myObservable.Subscribe(anyEvent =>
            {

                switch (anyEvent)
                {
                    case MyEvent1 myEvent1:
                        {
                            Console.WriteLine("I am subscriber2, MyEvent1 has arrived to me but I will not do anything");
                         
                            break;
                        }
                    case MyEvent2 myEvent2:
                        {
                            Console.WriteLine("I am subscriber2, MyEvent2 has arrived to me and I will print its content in the next line:");
                            Console.WriteLine(myEvent2.ToString());
                            break;
                        }
                    default:
                        break;
                }

            });
            Console.ReadLine();


        }
    }
}
