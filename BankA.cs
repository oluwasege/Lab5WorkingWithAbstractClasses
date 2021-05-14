using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5WorkingWithAbstractClasses
{
    class BankA : Bank
    {
        int balance = 100;
        public override void getBalance()
        {
            int input;
            Console.WriteLine("Welcome to Bank A\nWe are glad to have you with us\nPlease Press Enter");
            Console.ReadKey();
            Console.WriteLine("1 : Check your balance\n2 : cancel");
            string inputs = Console.ReadLine();
            while (!int.TryParse(inputs, out input))
            {
                Console.Clear();
                Console.WriteLine("Welcome to Bank A\nWe are glad to have you with us\n");
                Console.WriteLine("You entered a wrong input");
                Console.WriteLine("1: Check your balance\n2 : cancel");
                inputs = Console.ReadLine();
            }
            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine($"Your balance is : {balance}\n Thank you!");

            }
            else if (input == 2)
            {
                Environment.Exit(0);
            }

        }
    }
}
