namespace HW_3;

internal class Program
{
    static void Main(string[] args)
    {
        int[,] labirynth1 = new int[,]
            {
            {1, 0, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {2, 0, 0, 0, 1, 0, 2 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 },
            {1, 1, 1, 2, 1, 1, 1 }
            };

        int exits = new Labyrinth().HasExit(labirynth1, 0, 1);

       Console.WriteLine( $"Exits count: {exits}");

        

        
        
    }
}