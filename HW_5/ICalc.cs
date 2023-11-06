using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public interface ICalc
    {

        double Result { get; set; }
        void Sum(int x);
        void Sub(int x);
        void Div(int x);
        void Mult(int x);
        void CanselLast();

        event EventHandler<EventArgs> MyEventHandler;


    }
}
