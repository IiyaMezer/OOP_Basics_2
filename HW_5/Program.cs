namespace HW_5;

internal class Program
{
    static void Main(string[] args)
    {
        var calc = new Calc();
        calc.Result = 0D;
        calc.MyEventHandler += Calc_MyEventHandler;
        calc.Sum(10);
        calc.Sub(1);
        calc.Div(5);
        calc.Mult(10);

    }

    private static void Calc_MyEventHandler(object? sender, EventArgs e)
    {
        if(sender is Calc)
        
            Console.WriteLine(((Calc)sender).Result);
    }
}