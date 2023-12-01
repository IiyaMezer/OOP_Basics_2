using System.Xml;

namespace HW_9;

    internal class Program
    {
        static void Main(string[] args)
        {
        Convert converter = new();
		string jsonFilePath = "C:\\Users\\carna\\Source\\Repos\\IiyaMezer\\OOP_Basics_2\\FamilyTree\\ConsoleApp1\\generated.json";
		string outputXml = "C:\\Users\\carna\\Source\\Repos\\IiyaMezer\\OOP_Basics_2\\FamilyTree\\ConsoleApp1\\output.xml";
		try
		{
            converter.JsonToXml(jsonFilePath, outputXml);
            Console.WriteLine("Convertation succes");
        }
		catch (Exception ex)
		{

            Console.WriteLine($"Error: {ex}");
        }
        }
    }