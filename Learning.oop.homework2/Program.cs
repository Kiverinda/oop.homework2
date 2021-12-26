using System;

namespace Learning.oop.homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.SetAccountBalance(100000000);
            bankAccount.SetAccountNumber(1);
            bankAccount.SetAccountType(TypeAccountEnum.Personal);

            Console.WriteLine($"AccountNumber = {bankAccount.GetAccountNumber()}; AccountType = {bankAccount.GetAccountType()}; " +
                $"AccountBalance = {bankAccount.GetAccountBalance()}");
        }
    }
}
