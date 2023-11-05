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

        public event EventHandler<EventArgs> MyEventHandler;

        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }

        public double Div(int x)
        {
            Result /= x;
            PrintResult();
            return Result ;
        }

        public double Mult(int x)
        {
            Result *= x;
            PrintResult();

            return Result;
        }

        public double Sub(int x)
        {
            Result -= x;
            PrintResult();

            return Result ;
        }

        public double Sum(int x)
        {
            Result += x;
            PrintResult();

            return Result;
        }
    }
}
