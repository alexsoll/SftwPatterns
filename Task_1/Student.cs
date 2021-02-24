using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SftwPatterns
{
    class Student : IListener
    {
        Notebook book = new Notebook();
        public string name;

        public void Listen(string voice)
        {
            Console.WriteLine("The student heard: " + voice);
            Write(voice);
        }
        private void Write(string voice)
        {
            Console.WriteLine("The student writes: " + voice);
            book.Write(voice);
        }
    }
}
