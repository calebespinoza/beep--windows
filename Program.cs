using System;

namespace beep_windows
{
    class Beep {
        public void ringTheBell () {
            // Only works on Windows OS
            Console.Beep(2000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var beep = new Beep();
            Console.WriteLine("Ringing...");
            beep.ringTheBell();
            //Console.WriteLine("Hello World!");
        }
    }
}
