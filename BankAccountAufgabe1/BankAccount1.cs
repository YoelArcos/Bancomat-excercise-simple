using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAufgabe1
{
    public class BankAccount1
    {
        public  string Number { get; private set; }
        public  string Owner { get; private set; }
        public float Balance { get; private set; }

        public BankAccount1(string number, string owner, float balance)
        {
            this.Number= number;
            this.Owner= owner;
            this.Balance= balance;
        }
        
        public void MakeDeposit(float amount)
        {
            Balance += amount;
        }

        public void MakeWithdrawal(float amount) 
        {
            if(amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Unzureichender Saldo!\n");
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Kontostand von {Owner}: {Balance}\n");
        }
            
        }
    }

