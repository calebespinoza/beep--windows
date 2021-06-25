using System;

namespace beep_windows
{
    class Beep {
        public void ringTheBell () {
            Console.Beep(2000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var beep = new Beep();
            beep.ringTheBell();
            //Console.WriteLine("Hello World!");
        }
    }
}
