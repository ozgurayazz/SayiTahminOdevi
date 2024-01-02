using System.Runtime.CompilerServices;

namespace SayiTahminOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                Console.WriteLine("Sayı tahmin oyununa hoşgeldiniz.\nOynamak istediğiniz bölümü seçiniz (KOLAY-ORTA-ZOR)");
                string seviye = Console.ReadLine();
                if (seviye == "KOLAY")
                {
                    int sayi = rnd.Next(0, 11);
                    Console.WriteLine("1-10 dahil olmak üzere sayıyı belirledim 5 hakkın var tahmin et.");
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine($"{i}.Tahmin hakkın : ");
                        byte tahmin = byte.Parse(Console.ReadLine());
                        if (tahmin < sayi)
                        {
                            Console.WriteLine("Daha yüksek tahminde bulun.");
                        }
                        else if (tahmin > sayi)
                        {
                            Console.WriteLine("Daha düşük tahminde bulun.");
                        }
                        else if (tahmin == sayi)
                        {
                            Console.WriteLine("Doğru tahmin tebrikler.");
                            break;
                        }
                        else 
                        {
                            Console.WriteLine($"Kaybettin. Tuttuğum sayı = {sayi}");
                            break;
                        }
                    }
                }

                if (seviye == "ORTA")
                {
                    int sayi = rnd.Next(0, 51);
                    Console.WriteLine("1-50 Dahil olmak üzere sayıyı belirledim 10 hakkın var tahmin et.");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{i}. Tahmin hakkın : ");
                        byte tahmin = byte.Parse(Console.ReadLine());
                        if (tahmin < sayi)
                        {
                            Console.WriteLine("Daha yüksek tahminde bulun.");
                        }
                        else if (tahmin > sayi)
                        {
                            Console.WriteLine("Daha düşük tahminde bulun.");
                        }
                        else if (tahmin == sayi)
                        {
                            Console.WriteLine("Doğru tahmin tebrikler.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Kaybettin. Tuttuğum sayı = {sayi}");
                            break;
                        }
                    }
                }
                if (seviye == "ZOR")
                {
                    int sayi = rnd.Next(0, 101);
                    Console.WriteLine("1-50 Dahil olmak üzere sayıyı belirledim 20 hakkın var tahmin et.");
                    for (int i = 1; i <= 20; i++)
                    {
                        Console.WriteLine($"{i}. Tahmin hakkın : ");
                        byte tahmin = byte.Parse(Console.ReadLine());
                        if (tahmin < sayi)
                        {
                            Console.WriteLine("Daha yüksek tahminde bulun.");
                        }
                        else if (tahmin > sayi)
                        {
                            Console.WriteLine("Daha düşük tahminde bulun.");
                        }
                        else if (tahmin == sayi)
                        {
                            Console.WriteLine("Doğru tahmin tebrikler.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Kaybettin. Tuttuğum sayı = {sayi}");
                            break;
                        }
                    }
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Lütfen sayısal değer olarak giriş yapın");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lütfen değerler arasında bir sayı giriniz!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu.");
            }
        }

    }
}
