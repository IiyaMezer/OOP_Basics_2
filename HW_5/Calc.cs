﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    internal class Calc : ICalc
    {
        public double Result { get; set; }
        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEventHandler;

        public Dictionary<string, string> Commads { get; set; } = new Dictionary<string, string>()
        {
            {"+", "Сложение" },
            {"-", "Вычитание" },
            {"/", "Деление" },
            {"*", "Умножение" },
            {"reverse", "Оменить последнее " },
        };

        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }

        public void Div(int x)
        {
            Result /= x;
            PrintResult();
           
        }

        public void Mult(int x)
        {
            Result *= x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sub(int x)
        {
            Result -= x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sum(int x)
        {
            Result += x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void CanselLast()
        {
            if (LastResult.TryPop(out double res))
            {
                Result = res;
                PrintResult() ;
            }
            else
            {
                Console.WriteLine("нельзя отменить последнее действие.");
            }
        }
        private void PrintCommands()
        {
            Console.WriteLine("Commands:");
            foreach (var item in Commads)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
                Console.WriteLine();
            }
        }
        public int DataInput()
        {
            Console.WriteLine("Enter number:");
            string NumStr = Console.ReadLine()!;
            if (int.TryParse(NumStr, out int num)) { }
            Console.Clear();
            return num;
        }
        public void ExecuteCommand(int num)
        {
            PrintCommands();
            Console.WriteLine("Выберите операцию: ");
           string command = Console.ReadLine()!;

            if (Commads.ContainsKey(command))
            {
                switch(command)
                {
                    case "+":
                        Sum(num); break;
                    case "-":
                        Sub(num); break;
                    case "*":
                        Mult(num); break;
                    case "/":
                        Div(num); break;
                    case "reverse":
                        CanselLast(); break;
                }
            }

        }
    }
}