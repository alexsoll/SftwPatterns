using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SftwPatterns
{
    class Room
    {
        private List<IListener> listeners = new List<IListener>();

        public void Enter(IListener l)
        {
            Console.WriteLine("The " + l.GetType().Name + " entered");
            listeners.Add(l);
        }
        public void Exit(IListener l)
        {
            Console.WriteLine("The listener is left");
            listeners.Remove(l);
        }
        public void Say(string voice)
        {
            Console.WriteLine("The room spreads voice: " + voice);
            this.Distrib(voice);
        }
        private void Distrib(string voice)
        {
            Console.WriteLine("The room distrib voice: " + voice);
            foreach (var l in listeners)
            {
                l.Listen(voice);
            }
        }
    }
}
