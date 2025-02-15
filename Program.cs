// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçin: ");
        Console.WriteLine("1 - Toplama");
        Console.WriteLine("2 - Çıkarma");
        Console.WriteLine("3 - Çarpma");
        Console.WriteLine("4 - Bölme");

        int secim = Convert.ToInt32(Console.ReadLine());
        int sonuc = 0;

        switch (secim)
        {
            case 1:
                sonuc = sayi1 + sayi2;
                Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
                break;
            case 2:
                sonuc = sayi1 - sayi2;
                Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
                break;
            case 3:
                sonuc = sayi1 * sayi2;
                Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
                break;
            case 4:
                sonuc = sayi1 / sayi2;
                Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc}");
                break;
            default:
                Console.WriteLine("Geçersiz işlem seçimi");
                break;
        }
        Console.WriteLine("Program sonlandı");
    }
}
