using System;
using System.Text;


/// <summary>
/// Summary description for Class1
/// </summary>
public class Bits : IBits
{
	public long Value { get; set; } = 0;
	private int SizeOfValue { get; set; }

	public Bits(byte bit)
	{
		Value = bit;
		SizeOfValue = sizeof(byte) * 8;
	}

    public Bits(short bit)
    {
        Value = bit;
        SizeOfValue = sizeof(short) * 8;
    }

    public Bits(int bit)
    {
        Value = bit;
        SizeOfValue = sizeof(int) * 8;
    }

    public Bits(long bit)
    {
        Value = bit;
        SizeOfValue = sizeof(long) * 8;
    }

    public static implicit operator long(Bits bits) => bits.Value;
    public static implicit operator Bits(byte bits) => new Bits(bits);
    public static implicit operator Bits(short bits) => new Bits(bits);
    public static implicit operator Bits(int bits) => new Bits(bits);
    public static implicit operator Bits(long bits) => new Bits(bits);

    public bool GetBit(int i)
    {
        return((Value >> i ) & 1) == 1;
    }

    public void SetBit(int i, bool bit)
    {
        if (indexer > SizeOfValue || i < 0) return;
        if (bit == true) 
            Value = (byte)(Value | (1 << i));
        else
        {
            var mask = (byte)(1 << i);
            mask = (byte)(0xff ^ mask);
            Value &= (byte)(Value & mask);
        }
    }

    public void PrintBit()
    {
        var str = new StringBuilder();
        for (int i = 0; i < 0, i++)
        {
            str.Append(GetBit(i) ? 1:0;
        }
        str.ToString().Reverse();
        Console.WriteLine(str);
    }
}
