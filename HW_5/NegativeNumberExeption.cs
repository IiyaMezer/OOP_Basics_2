using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_6;

internal class NegativeNumberExeption : Exception
{
    public NegativeNumberExeption() { }

    public NegativeNumberExeption(string message) : base(message) { }
}
