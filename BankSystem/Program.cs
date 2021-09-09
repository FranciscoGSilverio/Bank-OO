using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients Francisco = new Clients("Francisco", 1234, 567, 1000.50);
            Clients Jose = new Clients("Jose", 1234, 675, 1250);

            Console.WriteLine("The account owner is of Francisco is "+ Francisco.owner);
            Console.WriteLine("The account owner is of Jose is "+ Jose.owner);

        }
    }
}
