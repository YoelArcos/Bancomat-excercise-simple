using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BankAccountAufgabe1;

namespace BankAccountAufgabe1
{
    internal class Programm
    {
        public static void Main(string[] args)
        {
            
            
                
            Console.WriteLine("Bitte gebe deinen Namen ein:");
            string ownerName = Console.ReadLine();
            

            Console.WriteLine("Gebe bitte deine 4-stellige Kartennummer ein:");
            string ownerNumber= Console.ReadLine();

            Console.WriteLine("Gebe bitte deinen Kontostand ein:");
            float balance = float.Parse(Console.ReadLine());

            BankAccount1 account = new BankAccount1(ownerNumber, ownerName, balance );


            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Aktion aus:");
                Console.WriteLine("1.Kontostand anzeigen");
                Console.WriteLine("2.Einzahlung machen");
                Console.WriteLine("3.Auszahlung machen");
                Console.WriteLine("4.Beenden");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    account.PrintBalance();

                }
                else if (input == "2")
                {
                    Console.WriteLine("Bitte geben sie den Betrag der eingezahlt werden soll.\n");
                    float depositAmount = float.Parse(Console.ReadLine());
                    account.MakeDeposit(depositAmount);

                }
                else if (input == "3")
                {
                    Console.WriteLine("Bitte geben sie den Betrag ein den sie abheben möchten.\n");
                    float withdrawalAmount = float.Parse(Console.ReadLine()); 
                    account.MakeWithdrawal(withdrawalAmount);
                }
                else if (input == "4")
                {

                    break;
                }
                else
                {
                    Console.WriteLine("ungültige Auswahl, erneut versuchen.\n");
                }
            }


        }
    }
}