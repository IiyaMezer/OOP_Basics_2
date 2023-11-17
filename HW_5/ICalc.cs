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
        void Sum(double x);
        void Sub(double x);
        void Div(double x);
        void Mult(double x);
        void CanselLast();

        event EventHandler<EventArgs> MyEventHandler;


    }
}
