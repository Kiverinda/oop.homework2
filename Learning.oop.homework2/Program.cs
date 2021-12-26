using System;

namespace Learning.oop.homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            Console.WriteLine($"AccountNumber = {bankAccount.AccountNumber}; AccountType = {bankAccount.AccountType}; " +
                $"AccountBalance = {bankAccount.AccountBalance}");

            BankAccount bankAccountWithBalance = new BankAccount(123456);

            Console.WriteLine($"AccountNumber = {bankAccountWithBalance.AccountNumber}; AccountType = {bankAccountWithBalance.AccountType}; " +
                $"AccountBalance = {bankAccountWithBalance.AccountBalance}");

            BankAccount bankAccountWithType = new BankAccount(TypeAccountEnum.Company);

            Console.WriteLine($"AccountNumber = {bankAccountWithType.AccountNumber}; AccountType = {bankAccountWithType.AccountType}; " +
                $"AccountBalance = {bankAccountWithType.AccountBalance}");

            BankAccount bankAccountWithBalanceAndType = new BankAccount(123456, TypeAccountEnum.Company);

            Console.WriteLine($"AccountNumber = {bankAccountWithBalanceAndType.AccountNumber}; AccountType = {bankAccountWithBalanceAndType.AccountType}; " +
                $"AccountBalance = {bankAccountWithBalanceAndType.AccountBalance}");
        }
    }
}
