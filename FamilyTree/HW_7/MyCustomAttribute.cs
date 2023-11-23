using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7;

[AttributeUsage(AttributeTargets.Field)]
public class MyCustomAttribute:Attribute
{


    public string FieldName { get;}

    public MyCustomAttribute(string fieldName)
    {
        FieldName = fieldName;
    }

}
