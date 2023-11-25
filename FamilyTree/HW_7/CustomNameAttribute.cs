using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7;

[AttributeUsage(AttributeTargets.Property)]
public class CustomNameAttribute:Attribute
{


    public string FieldName { set; get; }

    public CustomNameAttribute(string fieldName)
    {
        FieldName = fieldName;
    }

}
