namespace Learning.oop.homework2
{
    internal class BankAccount
    {
        private int _accountNmber;
        private decimal _acccountBalance;
        private TypeAccountEnum _accountType;

        public void SetAccountNumber(int value) { _accountNmber = value; }
        public void SetAccountBalance(decimal value) { _acccountBalance = value; }
        public void SetAccountType(TypeAccountEnum value) { _accountType = value; }
        public int GetAccountNumber() { return _accountNmber; }
        public decimal GetAccountBalance() { return _acccountBalance; }
        public TypeAccountEnum GetAccountType() { return _accountType; }
    }
}
