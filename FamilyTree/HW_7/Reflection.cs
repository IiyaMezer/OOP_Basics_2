using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW_7;

public static class Reflection
{
    public static string ObjectToString(object obj)
    {
        StringBuilder result = new StringBuilder();
        Type type = obj.GetType();

        foreach (FieldInfo fieldInfo in type.GetFields())

        {

            MyCustomNameAttribute attribute = fieldInfo.GetCustomAttribute<MyCustomNameAttribute>();



            if (attribute != null)

            {

                string fieldName = attribute.FieldName;

                object fieldValue = fieldInfo.GetValue(obj);



                result.AppendFormat($"{fieldName}:{fieldValue}");

                result.AppendLine();

            }

        }



        return result.ToString();
    }

    public static string StringToObject(object obj) { return null; }
}
