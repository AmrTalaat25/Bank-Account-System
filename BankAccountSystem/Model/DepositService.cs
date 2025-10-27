using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Model;
public static class DepositService
{
    public static void Deposit(List<BankAccount> accounts)
    {
        BankAccount account= FindAccountService.FindAccount(accounts);
        if (account == null)
            return;
        Console.Write("Enter Amount : ");
        double amount =double.Parse(Console.ReadLine()); 
        if (amount < 0)
            Console.WriteLine("Amount must be positive");

        account.Balance+=amount;
        Console.WriteLine($" Deposited {amount}. New balance: {account.Balance}");

    }
}
