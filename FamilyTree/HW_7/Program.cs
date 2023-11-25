namespace HW_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testObj = new TestClass(1, "Hi", 3.0m, new char[] { 'A', 'B', 'C' });            

            Console.WriteLine(Reflection.ObjectToString(testObj));
        }
    }
}