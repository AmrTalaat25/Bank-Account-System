using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Model;
public class BankAccount
{
    public int AccountId { get; set; }
    public string? AcountName { get; set; } 
    public double Balance { get; set; }
    public BankAccount(int id , string name , double balance)
    {
        AccountId = id;
        AcountName = name;
        Balance = balance;
        
    }
}
