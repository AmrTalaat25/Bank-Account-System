
using BankAccountSystem.Model;
using BankAccountSystem.Services;
using System.Security.Principal;

List<BankAccount> accounts = new List<BankAccount>();
while (true) { 
Console.WriteLine("\n====== BANK ACCOUNT SYSTEM ======");
Console.WriteLine("1 Create Account");
Console.WriteLine("2 Deposit Money");
Console.WriteLine("3 Withdraw Money");
Console.WriteLine("4 Show Balance");
Console.WriteLine("5 Exit");
Console.Write("Choose an option: ");
string? choice = Console.ReadLine();


    switch (choice)
    {
        case "1":
            CreateNewAccount.CreateAccount(accounts);
            break;

        case "2":
            ProcessInAccount.Deposit(accounts);
            break;
    }
}

