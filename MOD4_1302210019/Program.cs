using System.Diagnostics.CodeAnalysis;

public class KodeBuah
{
    public static string getKodeBuah(string buah)
    {
        Dictionary<string, string> kodebuah = new Dictionary<string, string>();
        kodebuah.Add("Apel", "A00");
        kodebuah.Add("Aprikot", "B00");
        kodebuah.Add("Alpukat", "C00");
        kodebuah.Add("Pisang", "D00");
        kodebuah.Add("Paprika", "E00");
        kodebuah.Add("Blackberry", "F00");
        kodebuah.Add("Ceri", "H00");
        kodebuah.Add("Kelapa", "I00");
        kodebuah.Add("Jagung", "J00");
        kodebuah.Add("Kurma", "K00");
        kodebuah.Add("Durian", "L00");
        kodebuah.Add("Anggur", "M00");
        kodebuah.Add("Melon", "N00");
        kodebuah.Add("Semangka", "O00");

     if (kodebuah.ContainsKey(buah))
       {
                return kodebuah[buah];
            }
            else
            {
                 return "Kode Buah ditemukan";
            }
        }
}

    class Program
    {
        static void Main(String[] args)
        {
            KodeBuah kodebuah = new KodeBuah();
            string buah = "Apel";
            string kodebuahbuah = KodeBuah.getKodeBuah(buah);
            Console.WriteLine(buah +" : "+ kodebuahbuah);
        }
    }


