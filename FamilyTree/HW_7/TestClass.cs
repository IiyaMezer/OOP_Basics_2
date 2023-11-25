using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7;

public class TestClass
{
    [CustomName("Int")]
    public int I { get; set; }
    [CustomName("string")]
    private string? S { get; set; }
    [CustomName("decimal")]
    public decimal D { get; set; }
    [CustomName("Char")]
    public char[]? C { get; set; }

    public TestClass()
    { }
    public TestClass(int i)
    {
        this.I = i;
    }
    public TestClass(int i, string s, decimal d, char[] c) : this(i)
    {
        this.S = s;
        this.D = d;
        this.C = c;

    }
}
