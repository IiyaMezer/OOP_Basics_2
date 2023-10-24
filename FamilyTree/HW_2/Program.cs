namespace HW_2;

internal class Program
{
    static void Main(string[] args)
    {

        int sint = 5566;
        Bits bitInt = sint;

        short sshort = 777;
        Bits bitShort = sshort;

        byte ebyte = 81;
        Bits bitByte = ebyte;

        long slong = 56L;
        Bits bitLong = slong;


        bitInt.PrintBit();
        bitShort.PrintBit();
        bitByte.PrintBit();
        bitLong.PrintBit();
    }
}