using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Model;
public static class FindAccountService
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

}
