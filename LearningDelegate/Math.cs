using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    class Math
    {
        public static int n = 10;
        public static int Sum(int number)
        {
            return n += number;
        }
        public static int Multiple(int number)
        {
            return n *= number;
        }
        public static int GetNumber()
        {
            return n;
        }
    }
}
