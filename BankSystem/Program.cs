using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           Manager Henrique = new Manager (){
               Name ="Henrique",
               Id = "123.123.132-00",
               Wage = 5000,
               NumberOfAgencys = 3
           };
           Henrique.Bonus = Henrique.Wage;

            Salesperson Marcos = new Salesperson (){
               Name ="Marcos",
               Id = "322.567.132-00",
               Wage = 2500,
               NumberOfClients = 10
           };
           Marcos.Bonus = Marcos.Wage;

           Salesperson Bruno = new Salesperson (){
               Name ="Bruno",
               Id = "908.123.132-00",
               Wage = 3000,
               NumberOfClients = 8
           };
           Bruno.Bonus = Bruno.Wage;

           Salesperson Mateus = new Salesperson (){
               Name ="Mateus",
               Id = "444.123.111-00",
               Wage = 2800,
               NumberOfClients = 8
           };
           Mateus.Bonus = Mateus.Wage;

            Clients Francisco = new Clients ("Francisco Gabriel Carvalho Silvério", 200, 111, 5000, Bruno);
            Clients Fernando = new Clients ("Fernando", 200, 222, 3000, Marcos);
            Clients Joao = new Clients ("Joao", 200, 222, 5500, Mateus);


            Console.WriteLine("====Bank System====");

            Console.WriteLine("Account 1: \nName: " + Francisco.Owner + ";" + "\nAgency: " + Francisco.Agency + ";" + "\nAccount: " + Francisco.Account + ";" + "\nCash: " + Francisco.Cash + ";");
            Console.WriteLine();
            Console.WriteLine("Account 2: \nName: " + Fernando.Owner + ";" + "\nAgency: " + Fernando.Agency + ";" + "\nAccount: " + Fernando.Account + ";" + "\nCash: " + Fernando.Cash + ";");
            Console.WriteLine();
            Console.WriteLine("Account 3: \nName: " + Joao.Owner + ";" + "\nAgency: " + Joao.Agency + ";" + "\nAccount: " + Joao.Account + ";" + "\nCash: " + Joao.Cash + ";");

            Console.WriteLine();

            Console.WriteLine("===Employees===");
            
            Console.WriteLine("Salesperson 1: \nName: " + Marcos.Name + ";" + "\nID: " + Marcos.Id + ";" + "\nWage: R$" + Marcos.Wage + ";" + "\nBonus R$: " + Marcos.Bonus + ";" + "\nTotal payment: R$" + Marcos.TotalPayment(Marcos.Wage,Marcos.Bonus) + ";" + "\nVacation " + Marcos.CalculateVacation() + " days.");
            Console.WriteLine();
            Console.WriteLine("Salesperson 1: \nName: " + Bruno.Name + ";" + "\nID: " + Bruno.Id + ";" + "\nWage: R$" + Bruno.Wage + ";" + "\nBonus R$: " + Bruno.Bonus + ";" + "\nTotal payment: R$" + Bruno.TotalPayment(Bruno.Wage,Bruno.Bonus) + ";" + "\nVacation " + Bruno.CalculateVacation() + " days.");
            Console.WriteLine();
            Console.WriteLine("Salesperson 1: \nName: " + Mateus.Name + ";" + "\nID: " + Mateus.Id + ";" + "\nWage: R$" + Mateus.Wage + ";" + "\nBonus R$: " + Mateus.Bonus + ";" + "\nTotal payment: R$" + Mateus.TotalPayment(Mateus.Wage,Mateus.Bonus) + ";" + "\nVacation " + Mateus.CalculateVacation() + " days.");
            Console.WriteLine();
            Console.WriteLine("Total of accounts: "+ Clients.AccountsCreated+".");
        }
    }
}
