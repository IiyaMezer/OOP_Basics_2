using System;
using System.Collections.Generic;
using System.Dynamic;
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
        result.Append(type.AssemblyQualifiedName + ":");
        result.Append(type.Name + ":");
        result.AppendLine();
        var properties = type.GetProperties(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);


        foreach (var fieldInfo in properties)

        {
            CustomNameAttribute attribute = fieldInfo.GetCustomAttribute<CustomNameAttribute>();

            if (attribute != null)
            {
                string fieldName = attribute.FieldName;
                object fieldValue = fieldInfo.GetValue(obj);

                if (fieldInfo.PropertyType == typeof(char[]))
                {
                    result.AppendFormat($"{fieldName}:{new String(fieldValue as char[])}");
                }
                else
                {
                    result.AppendFormat($"{fieldName}:{fieldValue}");
                }

                result.AppendLine();


            }
        }
        return result.ToString();
    }

    public static object StringToObject(string data)
    {

        string[] lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        var classAssemblyAndName = lines[0].Split(':');
        var result = Activator.CreateInstance(null, classAssemblyAndName[1])?.Unwrap();
        var type = result.GetType();
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        for (int i=1; i < lines.Length-1; i++)
        {
            string[] keyValue = lines[i].Split(':');            
            PropertyInfo fieldType = type.GetProperty(keyValue[0]);
            string fieldValue = keyValue[1];
            Console.WriteLine($"{fieldType}:{fieldValue}");
            var property = properties.FirstOrDefault(type => GetFieldType(type) == keyValue[0]);

            if (property.PropertyType == typeof(int))
            {
                fieldType.SetValue(result, int.Parse(fieldValue));
            }
            if (property.PropertyType == typeof(string))
            {
                fieldType.SetValue(result, fieldValue);
            }
            if (property.PropertyType == typeof(decimal))
            {
                fieldType.SetValue(result, decimal.Parse(fieldValue));
            }
            if (property.PropertyType == typeof(char[]))
            {
                fieldType.SetValue(result, fieldValue.ToCharArray());
            }

        }
        return result;
    }

    private static string GetFieldType(PropertyInfo propertyInfo)
    {
        var attribute =(CustomNameAttribute) Attribute.GetCustomAttribute(propertyInfo, typeof(CustomNameAttribute));
        return attribute !=null ? attribute.FieldName : propertyInfo.Name;

    }

}
