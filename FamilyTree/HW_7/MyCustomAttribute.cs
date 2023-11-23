using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7;

[AttributeUsage(AttributeTargets.Property)]
public class MyCustomNameAttribute:Attribute
{


    public string FieldName { get;}

    public MyCustomNameAttribute(string fieldName)
    {
        FieldName = fieldName;
    }

}
