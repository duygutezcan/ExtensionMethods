// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

internal class Program
{
    private static void Main(string[] args)
    {
        string isim = "duygu";
        Console.WriteLine(isim.IlkHarfBuyuk());

        //2.yol
        //Console.WriteLine(Extensions.IlkHarfBuyuk("duygu"));

       DateTime D = DateTime.Now;
        Console.WriteLine(D.Ayadi());

    }
}