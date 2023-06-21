// Mini Atm Uygulamasi
//Kullaniciya yapmak istedigi islemi soracagiz
//1- Bakiye görüntüleme
//2-Para cekme
//3-Para yatirma
//q-Cikis yapma
//Belirtilen deger disinda deger girilirse- "Lütfen gecerli bir deger girin"

namespace MiniAtm
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            
            Console.WriteLine("Atm'ye Hosgeldiniz");
            Console.WriteLine("Lütfen yapmak istediginiz islemi seciniz:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki Bakiyeniz" +bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Cekmek istediginiz tutar:");
                int cekilecek_tutar = Convert.ToInt32((Console.ReadLine()));
                
                Console.WriteLine("Kalan Tutar:" +(bakiye-cekilecek_tutar));
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırılacak Tutar");
                int yatirilacak_tutar = Convert.ToInt32((Console.ReadLine()));
                
                Console.WriteLine("Yeni bakiye:" +(bakiye+yatirilacak_tutar));
            }
            else if (secim == "q")
            {
                Console.WriteLine("ATM'den cikis yapiliyor");
                Console.WriteLine("Cikis yapildi, iyi günler...");
            }
            else
            {
                Console.WriteLine("Lütfen gecerli bir deger giriniz");
                Console.ReadLine();
            }
        }
    }
}



