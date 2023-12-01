using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace HW_9;

public class Convert
{
    /// <summary>
    /// Конвертация json строки в xml 
    /// </summary>
    /// <param name="jsonSring">json as sring</param>
    /// <returns>XML string</returns>
    public static XmlDocument JsonToXml(string jsonSring)
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlElement root = xmlDoc.CreateElement("root");
        xmlDoc.AppendChild(root);
        using(JsonDocument document = JsonDocument.Parse(jsonSring))
        {
            foreach (JsonProperty property in document.RootElement.EnumerateObject())
            {
                XmlElement element = JsonToXmlProp(xmlDoc, property);
                root.AppendChild(element);
            }
        }
        return xmlDoc;
    }

    private XmlElement JsonToXmlProp(XmlDocument xmlDoc, JsonProperty property)
    {
        XmlElement element = xmlDoc.CreateElement(property.Name);

        switch (property.Value.ValueKind)
        {
            case JsonValueKind.String:
                element.InnerText = property.Value.GetString();
                break;
            case JsonValueKind.Number:
                element.InnerText = property.Value.GetRawText();
                break;
            case JsonValueKind.True:
            case JsonValueKind.False:
                element.InnerText = property.Value.GetBoolean().ToString();
                break;
            default:
                throw new InvalidDataException("data error");
        }
        return element;
    }

    public static void SaveXmlToFile(XmlDocument xmlDoc, string filePath)
    {
        xmlDoc.Save(filePath);
    }
}
