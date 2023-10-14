using FamilyTree;

namespace ConsoleApp1;

    internal class Program
    {
        static void Main(string[] args)
        {
            //муж и жена
            FamilyMember Ira = new FamilyMember("Ira", new DateTime(1997, 12, 12), Gender.Female);
            FamilyMember ilya = new FamilyMember("Ilya", new DateTime(1997, 07, 21), Gender.Male);
            //дети иры и ильи
            FamilyMember olga = new FamilyMember("Olga", new DateTime(2022, 07, 19), Gender.Female);
            //Брат ольги
            FamilyMember rus = new FamilyMember("Ruslan", new DateTime(2001, 02, 21), Gender.Male);
            //Родители ильи
            FamilyMember victor = new FamilyMember("Victor", new DateTime(1962, 07, 20), Gender.Male);
            FamilyMember nat = new FamilyMember("Matalia", new DateTime(1967, 04, 01), Gender.Female);
            //Родители Иры
            FamilyMember nike = new FamilyMember("Nikita", new DateTime(1958, 01, 28), Gender.Male);
            FamilyMember toma = new FamilyMember("Tamara", new DateTime(1954, 08, 12), Gender.Female);
            //Брат иры
            FamilyMember oleg = new FamilyMember("Oleg", new DateTime(2019, 11, 13), Gender.Male);

            Console.WriteLine(Ira.ToString());
            Console.WriteLine(ilya.ToString());
            Console.WriteLine(olga.ToString());
            Console.WriteLine(victor.ToString());
            Console.WriteLine(oleg.ToString());
    }
    }