public class Employee
    {
        public string Name {get;set;}
        public string Id {get;set;}
        public string Occupation {get;set;}
        public double Wage {get;set;}
        public double Comission{get;set;}

        public Employee(string employee_name, string employee_id, string employee_occupation, double employee_wage)
        {
            Name = employee_name;
            Id = employee_id;
            Occupation = employee_occupation;
            Wage = employee_wage;
        } 
    }