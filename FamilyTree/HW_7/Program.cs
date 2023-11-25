namespace HW_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testObj = new TestClass(1, "Hi", 3.0m, new char[] { 'A', 'B', 'C' });

            string data = Reflection.ObjectToString(testObj);

            Console.WriteLine(Reflection.ObjectToString(testObj));

            TestClass testObj2 = new();


            Reflection.StringToObject(data);


        }
    }
}