public class Clients{
    public string Owner {get;set;}
    public int Agency {get;set;}
    public int Account{get;set;}
    public static int AccountsCreated{get;set;}
    public static double TotalComission{get;set;}
    private double _cash;
    public double Cash{get{
        return this._cash;
    }
    set{
        if(value >= 0){
            this._cash = value;
        }
        }
    }

    public Clients(string Clients_owner, int Clients_agency, int Clients_account, double Clients_cash, Employee employee){
        Owner = Clients_owner;
        Agency = Clients_agency;
        Account = Clients_account;
        Cash = Clients_cash;

        AccountsCreated++;
        TotalComission += Clients_cash*0.01;
        employee.Comission = Clients_cash*0.01;
    }

    public bool Withdraw(double value){
        if(this.Cash < value) return false;

        else {
            this.Cash -= value;
            return true;
        }
    }

    public void Deposit(double value){
        this.Cash += value;
    }

    public bool Transfer(double value, Clients destination){
        if(this.Cash < value) return false;

        else{
            this.Withdraw(value);
            destination.Deposit(value);
            return true;
        }
    }

    public double CashCheck(){
        return this.Cash;
    }
}