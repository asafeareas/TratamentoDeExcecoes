namespace Tratamento {
    class Account {

        public int Number {get; set;}
        public string Holder {get; set;}
        public double Balance {get; set;}
        public double WithdrawLimit {get; set;}
        
        public Account (){

        }

        public Account (int number, string holder, double balance, double withdrawlimit){
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlimit;
        }

        public void Deposit (double amount) {
            Balance += amount;
        }

        public void withdraw(double amount) {
            if (amount > WithdrawLimit) {
                throw new DomainException("This amount exceeds withdraw limit"); // Criando uma exceção personalizada
            } if (amount > Balance) {
                throw new DomainException("Not enough balance");
            } Balance -=amount;
        }
    }
}