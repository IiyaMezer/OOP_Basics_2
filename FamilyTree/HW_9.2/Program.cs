using System.Xml;

namespace HW_9;

internal class Program
{
    static void Main(string[] args)
    {
        JsonXmlConverter converter = new();
        //string jsonFilePath = "C:\\Users\\carna\\Source\\Repos\\IiyaMezer\\OOP_Basics_2\\FamilyTree\\HW_9.2\\generated.json";
        //string outputXml = "C:\\Users\\carna\\Source\\Repos\\IiyaMezer\\OOP_Basics_2\\FamilyTree\\HW_9.2\\output.xml";

        string jsonFilePath = args[0];
        string outputXml = args[1];

        converter.ConvertJsonToXml(jsonFilePath, outputXml);
    }
}