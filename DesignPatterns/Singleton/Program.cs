using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var evenRepo = new EvenIndiceRepo();
            var oddRepo = new OddIndiceRepo();
            
            foreach(var entry in evenRepo.Get())
            {
                Console.WriteLine(entry);
            }
            foreach (var entry in oddRepo.Get())
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }
    }
}
