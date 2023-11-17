using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_6;

    internal class MyParsing
{
    /// <summary>
    /// Парсинг строки в Double,
    /// Если формат введеных данных не соответсвует действию,
    /// то ловится Format exeption с сообщением в консоли,
    /// при этом введенной переменной приваивается 0, чтобы избежать null
    /// ибо действие программы не прекращается
    /// </summary>
    /// <param name="input">данные в формате строки</param>
    /// <param name="data">конвертированное значение в double</param>
    /// <returns>true/false</returns>
    public static bool TryParseDouble(string input, out double data)
    {
        try
        {
            data = double.Parse(input);
        }
        catch(FormatException e) 
        {
            Console.WriteLine(e.Message);
            data  = 0;
            return false;
        }
        return true;
    }
}

