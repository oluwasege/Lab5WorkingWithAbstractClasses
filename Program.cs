using System;

namespace Lab5WorkingWithAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int bankSelection;
            Console.WriteLine("Welcome!\n1 : Bank A\n2 : Bank B\n3 : Bank C");
            string bankSelections = Console.ReadLine();
            //while (string.IsNullOrEmpty(bankSelections))
            //{
            //    Console.WriteLine("Cannot be left Empty\nWelcome!\nPlease Enter 1 for Bank A, 2 for Bank B and 3 for Bank C");
            //    bankSelections = Console.ReadLine();
            //}
            //Menu Selection Validation
            while(!int.TryParse(bankSelections, out bankSelection))
            {
                Console.Clear();
                Console.WriteLine("You entered a worng input\n\nWelcome!\n1 : Bank A\n2 : Bank B\n3 : Bank C");
                bankSelections = Console.ReadLine();
            }
            if(bankSelection==1)
            {
                BankA firsbank = new BankA();
                Console.Clear();
                firsbank.getBalance();
            }
            else if(bankSelection==2)
            {
                BankB seconBank = new BankB();
                Console.Clear();
                seconBank.getBalance();
            }
            else if(bankSelection==3)
            {
                BankC thirdBank = new BankC();
                Console.Clear();
                thirdBank.getBalance();
            }
            
        }
    }
}
