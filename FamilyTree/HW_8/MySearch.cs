using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8;

internal class MySearch
{
    public static void Files(string dir, string pattern, string text)
    {
        foreach (string file in Directory.GetFiles(dir, pattern))
        {
            if(FileContainstext(file, text))
            {
                Console.WriteLine(file);
            }
        }

        foreach (string subdir in Directory.GetDirectories(dir))
        {
            Files(subdir, pattern, text);
        }
    }

    private static bool FileContainstext(string file, string text)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(text))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
