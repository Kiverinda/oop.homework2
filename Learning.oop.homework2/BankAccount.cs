namespace Learning.oop.homework2
{
    internal class BankAccount
    {
        private int _accountNmber;
        private decimal _accountBalance;
        private TypeAccountEnum _accountType;
        private static int _countAccount;

        public BankAccount()
        {
            _accountNmber = SetAccountNumber();
        }

        public BankAccount(decimal accountBalance) : this()
        {
            _accountBalance = accountBalance;
        }

        public BankAccount(TypeAccountEnum accountType) : this()
        {
            _accountType = accountType;
        }

        public BankAccount(decimal accountBalance, TypeAccountEnum accountType) : this()
        {
            _accountBalance = accountBalance;
            _accountType = accountType;
        }

        public int GetAccountNumber() { return _accountNmber; }
        public decimal GetAccountBalance() { return _accountBalance; }
        public TypeAccountEnum GetAccountType() { return _accountType; }

        private int SetAccountNumber() { return _countAccount++; }
    }
}
