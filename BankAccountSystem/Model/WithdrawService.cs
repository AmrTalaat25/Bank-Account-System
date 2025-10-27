using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Model;
public static class WithdrawService
{
    public static void Withdraw(List<BankAccount> accounts)
    {
        BankAccount account = FindAccountService.FindAccount(accounts);
        if (account == null) 
            return;
        Console.Write("Enter Amount of Withdraw : ");
        double amount = double.Parse(Console.ReadLine());
        if (amount < 0)
            Console.WriteLine("Amount must be positive!");
        else
        {
            if (amount > account.Balance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Not enough money !!!");
                Console.WriteLine($"Enter Amount less than or equal {account.Balance} ");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                account.Balance -= amount;
                Console.WriteLine($" Withdraw {amount}. New balance: {account.Balance}");
            }


        }


    }
}
