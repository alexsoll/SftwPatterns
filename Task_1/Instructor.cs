using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SftwPatterns
{
    class Instructor : IListener
    {
        public void Listen(string voice)
        {
            Console.WriteLine("The instructor heard: " + voice);
        }
        public void Say(Room r, string voice)
        {
            Console.WriteLine("Instructor say: " + voice);
            r.Say(voice);
        }
    }
}
