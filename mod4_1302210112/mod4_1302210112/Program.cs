// See https://aka.ms/new-console-template for more information



internal class Program
{
    public enum buah
    {
        apel,
        aprikot,
        alpukat,
        pisang,
        paprika,
        blackberry,
        ceri,
        kelapa,
        jagung
    }
    public static string getKode(buah b)
    {
        string[] kdbuah =
        {
            "A00","C00","C00","d00","E00","F00","H00","I00","J00"
        };
        return kdbuah[(int)b];
    }

    private static void Main(string[] args)
    {
        
        buah b=buah.apel;
        Console.WriteLine("buah" + b + "kode buah" + getKode(b);
    }
}