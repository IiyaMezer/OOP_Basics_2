namespace HW_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("patern: Utility.exe <ext> <text>");
                return;
            }

            string ext = args[0];
            string pattern = "*" + ext;
            string searchedText = args[1];

            string currDir = Directory.GetCurrentDirectory();

            try
            {
                MySearch.Files(currDir, pattern, searchedText);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }

        }
    }
}