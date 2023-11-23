using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7;

internal class TestClass
{
    [MyCustomName("CustomFieldName")]
    public int I { get; set; }
    [MyCustomName("CustomFieldName")]
    private string? S { get; set; }
    [MyCustomName("CustomFieldName")]
    public decimal D { get; set; }
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
