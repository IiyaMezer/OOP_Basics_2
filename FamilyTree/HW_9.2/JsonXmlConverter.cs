using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace HW_9;

class JsonXmlConverter
{
    /// <summary>
    /// Конвертация из json to xml
    /// </summary>
    /// <param name="jsonFilePath">json filepath</param>
    /// <param name="xmlFilePath"> xml filepath</param>
    public void ConvertJsonToXml(string jsonFilePath, string xmlFilePath)
    {
        try
        {
            string json = File.ReadAllText(jsonFilePath);
            XmlDocument xmlDoc = CreateXmlFromJson(json);
            SaveXmlToFile(xmlDoc, xmlFilePath);
            Console.WriteLine("Преобразование JSON в XML выполнено успешно.");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"JSON error: {ex.Message}");
        }
        catch (XmlException ex)
        {
            Console.WriteLine($"XM error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    /// <summary>
    /// Преобразование json в XMLдокумент
    /// и его наполнение поэлементно
    /// </summary>
    /// <param name="json">json as string</param>
    /// <returns>Converted Xml </returns>
    private XmlDocument CreateXmlFromJson(string json)
    {
        XmlDocument xmlDoc = new XmlDocument();
         XmlElement root = xmlDoc.CreateElement("root");

        XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        xmlDoc.AppendChild(root);

        using (JsonDocument document = JsonDocument.Parse(json))
        {
            foreach (JsonProperty property in document.RootElement.EnumerateObject())
            {
                XmlElement element = XmlPropsFromJson(xmlDoc, property);
                root.AppendChild(element);
            }
        }
        xmlDoc.InsertBefore(xmlDeclaration, root);
        return xmlDoc;
    }
    /// <summary>
    /// Логика преобразования поллей из одного формата в другой
    /// и заполнение документа
    /// </summary>
    /// <param name="xmlDoc"></param>
    /// <param name="property"></param>
    /// <returns>Элемент который записывается в файл</returns>
    /// <exception cref="InvalidDataException"></exception>
    private XmlElement XmlPropsFromJson(XmlDocument xmlDoc, JsonProperty property)
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
                throw new InvalidDataException("Synthax JSON error");
        }

        return element;
    }
    /// <summary>
    /// Запись XML элемента в файл
    /// </summary>
    /// <param name="xmlDoc">записываемый документ</param>
    /// <param name="filePath">путь к существующему файлу</param>
    private void SaveXmlToFile(XmlDocument xmlDoc, string filePath)
    {
        xmlDoc.Save(filePath);
    }
}