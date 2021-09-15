public class Clients{
    public string owner;
    public int agency;
    public int account;
    public double cash;

    public Clients(string owner, int agency, int account, double cash){
        this.owner = owner;
        this.agency = agency;
        this.account = account;
        this.cash = cash;
    }

    public bool Withdraw(double value){
        if(this.cash < value) return false;

        else {
            this.cash -= value;
            return true;
        }
    }

    public void Deposit(double value){
        this.cash += value;
    }

    public bool Transfer(double value, Clients destination){
        if(this.cash < value) return false;

        else{
            this.Withdraw(value);
            destination.Deposit(value);
            return true;
        }
    }
}