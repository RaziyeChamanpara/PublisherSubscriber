using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    public class Publisher
    {
        public delegate void PublishedDelegate(string message);
        public PublishedDelegate Published { get; set; }

        void OnPublish(string message)
        {
            if (Published != null)
                Published(message);
        }
        public void Publish(string message)
        {
            Console.WriteLine("Publisher:" + message);
            OnPublish(message);
        }
    }
}
