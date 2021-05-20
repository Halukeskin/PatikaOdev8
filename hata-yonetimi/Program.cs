using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Bir sayı giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı:" +sayi);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine("Bir değer girdiniz:");
                Console.WriteLine(ex);
            }


        }
    }
}
