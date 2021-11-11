public class Manager : Employee
{
    public int NumberOfAgencys {get;set;}

    public override double Bonus
    {
        get{
            return _bonus;
        }
        set{
            _bonus += 12 * (value +0.05);
        }
    }
    public override int CalculateVacation()
    {
        int vacationDays = 30 + NumberOfAgencys *5;
        return vacationDays;
    }
}