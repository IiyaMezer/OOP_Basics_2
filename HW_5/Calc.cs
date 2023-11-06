using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    internal class Calc : ICalc
    {
        public double Result { get; set; }
        private Stack<double> LastResult {  get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEventHandler;


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
    }
}
