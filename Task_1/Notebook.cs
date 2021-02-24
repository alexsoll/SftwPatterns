using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SftwPatterns
{
    class Notebook
    {
        private List<string> data = new List<string>();

        public void Write(string info)
        {
            Console.WriteLine("In the notebook was written: " + info);
            data.Add(info);
        }

    }
}
