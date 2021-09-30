using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeAna = new Employee("Ana", "567.567.567-20", "Cashier", 1550);
            Employee employeeJoaoVictor = new Employee("JoaoVictor", "902;902.902-10", "Cashier", 1420);
            
            Clients Francisco = new Clients("Francisco", 1234, 567, 1000.50, employeeAna);
            Clients Jose = new Clients("Jose", 1234, 675, 1250, employeeJoaoVictor);
            Clients Monica = new Clients("Monica", 1234, 789, 1330, employeeJoaoVictor);

            Console.WriteLine("The total of accounts created is: "+ Clients.AccountsCreated + " accont(s).");
            Console.WriteLine("");

            Console.WriteLine("Inicial money: Francisco R$" + Francisco.Cash + "; assisted by the cashier " + employeeAna.Name + ", her comission was: R$ "+ employeeAna.Comission);
            Console.WriteLine("Inicial money: Jose R$" + Jose.Cash + "; assisted by the cashier " + employeeJoaoVictor.Name + ", his comission was: R$ "+ employeeJoaoVictor.Comission);
            Console.WriteLine("Inicial money: Monica R$" + Monica.Cash + "; assisted by the cashier " + employeeJoaoVictor.Name + ", his comission was: R$ "+ employeeJoaoVictor.Comission);
            Console.WriteLine("");

            Francisco.Withdraw(100);
            Jose.Withdraw(250);
            Monica.Withdraw(500);

            Console.WriteLine("Francisco's cash after withdrawal: "+ Francisco.Cash);
            Console.WriteLine("Jose's cash after withdrawal: "+ Jose.Cash);
            Console.WriteLine("Monica's cash after withdrawal: "+ Monica.Cash);
            Console.WriteLine("");

            Francisco.Deposit(1200);
            Console.WriteLine("Francisco's cash after Deposit: "+Francisco.Cash);
            Console.WriteLine("");

            Francisco.Transfer(350, Jose);
            Console.WriteLine("Francisco's cash after transfer: "+Francisco.Cash);
            Console.WriteLine("Jose's cash after transfer: "+ Jose.Cash);
        }
    }
}
