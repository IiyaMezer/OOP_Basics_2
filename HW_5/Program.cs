namespace HW_5;

internal class Program
{
    static void Main(string[] args)
    {
        var calc = new Calc();
        calc.Result = 0D;
        calc.MyEventHandler += Calc_MyEventHandler;
        
        string command = String.Empty;
        string operation = String.Empty;
        int num = 0;

        bool f = true;
        while (f)
        {
            num = calc.DataInput();
            calc.ExecuteCommand(num);
            //Console.WriteLine("Type 'exit' to quit");
            //string exit = Console.ReadLine();
            //if (exit == "exit") 
            //{
            //    Console.WriteLine("Press any key to quit");
            //    f = false;
            //    Console.ReadKey();
            //}
        }




    }

    private static void Calc_MyEventHandler(object? sender, EventArgs e)
    {
        if(sender is Calc)
        
            Console.WriteLine(((Calc)sender).Result);
    }
}