// See https://aka.ms/new-console-template for more information



using static Program;

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
    public enum posisi { jongkok,berdiri,terbang,tengkurap}
    public enum Triger { tombolS,tombolW,tombolX }
    posisi saatIni = posisi.berdiri;
    public static string getKode(buah b)
    {
        string[] kdbuah =
        {
            "A00","C00","C00","d00","E00","F00","H00","I00","J00"
        };
        return kdbuah[(int)b];
    }
    public class transisi
    {
        public posisi awal;
        public posisi next;
        public Triger triger;
        public transisi(posisi awal, posisi next,Triger triger) 
        { 
            this.next = next;
            this.awal = awal;
            this.triger = triger;
        }
        transisi[] Transisi =
        {
             new transisi(posisi.tengkurap, posisi.jongkok, Triger.tombolW),
            new transisi(posisi.jongkok, posisi.tengkurap, Triger.tombolS),
            new transisi(posisi.berdiri,posisi.terbang, Triger.tombolW),
            new transisi(posisi.terbang,posisi.berdiri,Triger.tombolS),
            new transisi(posisi.terbang,posisi.jongkok,Triger.tombolX),
            new transisi(posisi.berdiri,posisi.jongkok,Triger.tombolS),
           new transisi(posisi.jongkok,posisi.berdiri,Triger.tombolX),
        };
       
    }
    public posisi berikut(posisi awal, Triger triger)
    {
        posisi akhir = awal;
        for (int i = 0; i < Transisi.Length; i++)
        {
            transisi berubah = Transisi[i];
            if (awal == berubah.awal && triger == berubah.triger)
            {
                akhir = berubah.akhir;
            }
        }
        return akhir;
    }

    private static void Main(string[] args)
    {
        
        buah b=buah.apel;
        Console.WriteLine("buah" + b + "kode buah" + getKode(b));
    }
}