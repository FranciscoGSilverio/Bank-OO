using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients Francisco = new Clients();
            Francisco.owner = "Francisco";
            Francisco.agency = 1234;
            Francisco.account = 567;
            Francisco.cash = 1000.50;

            Clients Jose = new Clients();
            Jose.owner = "Jose";
            Jose.agency = 1234;
            Jose.account = 675;
            Jose.cash = 1250;

            Console.WriteLine("The account owner is of Francisco is "+ Francisco.owner);
            Console.WriteLine("The account owner is of Jose is "+ Jose.owner);

        }
    }
}
