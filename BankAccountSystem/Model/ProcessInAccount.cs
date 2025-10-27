using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Model;
public static class ProcessInAccount
{
    public static BankAccount FindAccount(List<BankAccount> accounts)
    {
        Console.Write("Enter Acount ID :");
        int id=int.Parse(Console.ReadLine());
        BankAccount? bankAccount = accounts.Find(n => n.AccountId == id);
        if (bankAccount == null)
            Console.WriteLine("Account Not Found");
          
        return bankAccount;


    }
    public static void Deposit(List<BankAccount> accounts)
    {
        BankAccount account = FindAccount(accounts);
        if (account==null)
            return;
        Console.Write("Enter Acount Amount :");
        double amount = double.Parse(Console.ReadLine());

        if (amount < 0)
            Console.WriteLine("Amount must be positive!");
        account.Balance+= amount;
        Console.WriteLine($" Deposited {amount}. New balance: {account.Balance}");
    }
}
