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
        double Sum(int x);
        double Sub(int x);
        double Div(int x);
        double Mult(int x);

        event EventHandler<EventArgs> MyEventHandler;


    }
}
