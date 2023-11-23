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
        StringBuilder sb = new StringBuilder();
        Type type = obj.GetType();

        foreach (FieldInfo fieldInfo in type.GetFields())

        {

            MyCustomAttribute attribute = fieldInfo.GetCustomAttribute<MyCustomAttribute>();



            if (attribute != null)

            {

                string fieldName = attribute.FieldName;

                object fieldValue = fieldInfo.GetValue(obj);



                sb.AppendFormat($"{fieldName}:{fieldValue}");

                sb.AppendLine();

            }

        }



        return sb.ToString();
    }
}
