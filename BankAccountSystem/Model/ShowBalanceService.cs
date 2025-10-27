using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Model;
public static class ShowBalanceService
{
    public static void ShowBalance(List<BankAccount> accounts)
    {
        var account = FindAccountService.FindAccount(accounts);
        if (account == null) 
            return;
        else
            Console.WriteLine($" Account: {account.AcountName}, Balance: {account.Balance}");

    }
}
