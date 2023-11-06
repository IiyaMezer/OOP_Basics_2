namespace HW_5;

internal class Program
{
    static void Main(string[] args)
    {
        var calc = new Calc();

    }

    private static void Calc_MyEventHandler(object? sender, EventArgs e)
    {
        if(sender is Calc)
        
            Console.WriteLine(((Calc)sender).Result);
    }
}