using System.Xml;

namespace HW_9;

    internal class Program
    {
        static void Main(string[] args)
        {
		string jsonFilePath = "path";
		string json = File.ReadAllText(jsonFilePath);
		string outputXml = "output";
		try
		{
			XmlDocument xmlDoc = Convert.JsonToXml(json);
			Convert.SaveXmlToFile(xmlDoc, outputXml);
            Console.WriteLine("Convertation succes");
        }
		catch (Exception ex)
		{

            Console.WriteLine($"Error: ");
        }
        }
    }