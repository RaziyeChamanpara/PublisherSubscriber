using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subscriber subscriber1 = new Subscriber(publisher);
            Subscriber subscriber2 = new Subscriber(publisher);
            Subscriber subscriber3 = new Subscriber(publisher);

            publisher.Publish("hi");
        }
    }
}
