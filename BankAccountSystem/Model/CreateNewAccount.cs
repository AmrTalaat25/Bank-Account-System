using BankAccountSystem.Model;

namespace BankAccountSystem.Services
{
    public static class CreateNewAccount
    {
        public static void CreateAccount(List<BankAccount> accounts)
        {
            Console.Write("Enter account name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter balance: ");
            double balance = double.Parse(Console.ReadLine());

            int newAccId = accounts.Count + 1;
            BankAccount newAccount = new BankAccount(newAccId, name, balance);
            accounts.Add(newAccount);

            Console.WriteLine($" Account created --> ID: {newAccId}");
        }
    }
}
