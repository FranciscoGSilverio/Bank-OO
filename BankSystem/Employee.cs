public abstract class Employee
    {
        public string Name {get;set;}
        public string Id {get;set;}
        public double Wage {get;set;}
        public double Comission{get;set;}

       protected double _bonus;

       public virtual double Bonus{
           get{
               return _bonus;
           }
           set{
               _bonus += Wage * 0.01;
           }
       }

       public abstract int CalculateVacation();

       public double TotalPayment(double Wage){
           return Wage * 13;
       }
       public double TotalPayment(double Wage, double Bonus){
           return Wage * 13 + Bonus;
       }
    }