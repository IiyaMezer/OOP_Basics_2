using FamilyTree;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        //муж и жена
        FamilyMember? ira = new FamilyMember("Ira", new DateTime(1997, 12, 12), Gender.Female);
        FamilyMember? ilya = new FamilyMember("Ilya", new DateTime(1997, 07, 21), Gender.Male);
        //дети иры и ильи
        FamilyMember olga = new FamilyMember("Olga", new DateTime(2022, 07, 19), Gender.Female);
        //Брат ольги
        FamilyMember rus = new FamilyMember("Ruslan", new DateTime(2001, 02, 21), Gender.Male);
        //Родители ильи
        FamilyMember? victor = new FamilyMember("Victor", new DateTime(1962, 07, 20), Gender.Male);
        FamilyMember? nat = new FamilyMember("Matalia", new DateTime(1967, 04, 01), Gender.Female);
        //Родители Иры
        FamilyMember? nike = new FamilyMember("Nikita", new DateTime(1958, 01, 28), Gender.Male);
        FamilyMember? toma = new FamilyMember("Tamara", new DateTime(1954, 08, 12), Gender.Female);
        //Брат иры
        FamilyMember oleg = new FamilyMember("Oleg", new DateTime(2019, 11, 13), Gender.Male);

        victor.Wife = nat;
        nat.Husband = victor;

        nike.Wife = toma;
        toma.Husband = nike;

        ilya.Father = victor;
        ilya.Mother = nat;

        ira.Father = nike;
        ira.Mother = toma;

        oleg.Father = nike;
        oleg.Mother = toma;

        ira.Husband = ilya;
        ilya.Wife = ira;

        olga.Father = ilya;
        olga.Mother = ira;

        rus.Father = ilya;
        rus.Mother = ira;
        Console.WriteLine(olga);
        Console.WriteLine(victor.GetParents());
        Console.WriteLine(ilya.GetCloseRelative());
        Console.WriteLine(toma.GetCloseRelative());

    }
}