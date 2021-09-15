using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients Francisco = new Clients("Francisco", 1234, 567, 1000.50);
            Clients Jose = new Clients("Jose", 1234, 675, 1250);

            Console.WriteLine("The account owner of Francisco is "+ Francisco.owner);
            Console.WriteLine("The account owner of Jose is "+ Jose.owner);
            Console.WriteLine("");
            
            Francisco.Withdraw(100);
            Jose.Withdraw(250);

            Console.WriteLine("Francisco's cash: "+ Francisco.cash);
            Console.WriteLine("Jose's cash: "+ Jose.cash);
            Console.WriteLine("");

            Francisco.Deposit(1200);
            Console.WriteLine("Francisco's cash after Deposit: "+Francisco.cash);
            Console.WriteLine("");

            Francisco.Transfer(350, Jose);
            Console.WriteLine("Francisco's cash: "+Francisco.cash);
            Console.WriteLine("Jose's cash: "+ Jose.cash);
        }
    }
}
