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

    public static void StringToObject(string data , object obj)
    {
        string[] lines = data.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string line in lines)
        {
            string[] keyValue = line.Split(':');
            string fieldName = keyValue[0].Trim();
            string fieldValue = keyValue[1].Trim();

            foreach(FieldInfo fieldInfo in obj.GetType().GetFields())
            {
                MyCustomNameAttribute attribute = fieldInfo.GetCustomAttribute<MyCustomNameAttribute> ();

                if (attribute?.FieldName == fieldName)
                {
                    Type fieldType = fieldInfo.FieldType;
                    object parsedValue = Convert.ChangeType(fieldValue, fieldType);

                    fieldInfo.SetValue(obj, parsedValue);
                    break;
                }

            }
        }
    }

}
