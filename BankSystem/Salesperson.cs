public class Salesperson : Employee
{
    public int NumberOfClients {get;set;}

    public override double Bonus { 
        get {
            return _bonus;
        }
        set{
            _bonus += 12*(value*0.02);
        }
    }

    public override int CalculateVacation()
    {
        int vacationDays = 30 + NumberOfClients *1;
        return vacationDays;
    }
}