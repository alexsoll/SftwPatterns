using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SftwPatterns
{
    class Lesson
    {
        public static void Main()
        {
            Student s = new Student();
            Instructor i = new Instructor();
            Room r = new Room();

            r.Enter(s);
            r.Enter(i);
            i.Say(r, "Hello, students!");
            r.Exit(s);
            r.Exit(i);
            Console.ReadLine();
        }
    }
}
