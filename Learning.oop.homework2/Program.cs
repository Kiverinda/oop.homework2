using System;

namespace Learning.oop.homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            Console.WriteLine($"AccountNumber = {bankAccount.GetAccountNumber()}; AccountType = {bankAccount.GetAccountType()}; " +
                $"AccountBalance = {bankAccount.GetAccountBalance()}");

            BankAccount bankAccountWithBalance = new BankAccount(123456);

            Console.WriteLine($"AccountNumber = {bankAccountWithBalance.GetAccountNumber()}; AccountType = {bankAccountWithBalance.GetAccountType()}; " +
                $"AccountBalance = {bankAccountWithBalance.GetAccountBalance()}");

            BankAccount bankAccountWithType = new BankAccount(TypeAccountEnum.Company);

            Console.WriteLine($"AccountNumber = {bankAccountWithType.GetAccountNumber()}; AccountType = {bankAccountWithType.GetAccountType()}; " +
                $"AccountBalance = {bankAccountWithType.GetAccountBalance()}");

            BankAccount bankAccountWithBalanceAndType = new BankAccount(123456, TypeAccountEnum.Company);

            Console.WriteLine($"AccountNumber = {bankAccountWithBalanceAndType.GetAccountNumber()}; AccountType = {bankAccountWithBalanceAndType.GetAccountType()}; " +
                $"AccountBalance = {bankAccountWithBalanceAndType.GetAccountBalance()}");
        }
    }
}
