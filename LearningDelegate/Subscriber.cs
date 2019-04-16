using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDelegate
{
    public class Subscriber
    {

        public Subscriber(Publisher publisher)
        {
            publisher.Published += NewMessagePublished;
        }

        public void NewMessagePublished(string message)
        {
            Console.WriteLine("subscriber:" + message);
        }




    }
}
