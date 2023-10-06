using System;

namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara J för ja och N för nej");
            string Gymnasiet = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder < 22 && Gymnasiet == "J") 
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
            else
            {
                Console.WriteLine("Vi vill inte anställa dig");
            }
            
        }
    }
}
