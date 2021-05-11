﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5WorkingWithAbstractClasses
{
    class BankB : Bank
    {
        int balance = 150;
        public override void getBalance()
        {
            int input;
            Console.WriteLine("Welcome to Bank B\nWe are glad to have you with us\nPlease Press Enter");
            Console.ReadKey();
            Console.WriteLine("To Check your balance press 1 or 2 to cancel");
            string inputs = Console.ReadLine();
            while (!int.TryParse(inputs, out input))
            {
                Console.Clear();
                Console.WriteLine("Welcome to Bank B\nWe are glad to have you with us\n");
                Console.WriteLine("You entered a wrong input");
                Console.WriteLine("To Check your balance press 1 or 2 to cancel");
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
