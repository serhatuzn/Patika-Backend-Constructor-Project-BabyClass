using System; 

namespace Constructor_Project__Baby_Class_
{
    // Baby sınıfı, bir bebeğin ad, soyad ve doğum tarihi gibi özelliklerini içerir.
    public class Baby
    {
        // Private (özel) alan (field) sadece bu sınıf içinde kullanılabilir.
        // Bu alan, DogumTarih özelliğiyle ilişkilendirilecek.
        private DateTime _dogumTarih;

        // Ad ve SoyAd özellikleri, bebeğin adı ve soyadını tutar.
        // Otomatik özellik (auto-property) olarak tanımlandılar.
        public string Ad { get; set; }  // Bebeğin adı
        public string SoyAd { get; set; }  // Bebeğin soyadı

        // DogumTarih özelliği, _dogumTarih alanına erişim sağlar.
        // Bu özellik ile doğum tarihine kontrollü bir şekilde erişiyoruz.
        public DateTime DogumTarih
        {
            get 
            { 
                // Doğum tarihini döndürür (get işlemi).
                return _dogumTarih; 
            }
            set 
            {
                // Eğer girilen tarih, minimum değerden küçükse, hata mesajı gösterilir.
                if (value < DateTime.MinValue)
                {
                    Console.WriteLine("Yanlış doğum tarihi girildi.");
                    // Yanlış giriş durumunda, minimum geçerli tarihi atıyoruz.
                    _dogumTarih = DateTime.MinValue;
                }
                else
                {
                    // Geçerli bir tarih girildiyse, bu değer _dogumTarih'e atanır.
                    _dogumTarih = value;
                }
            }
        }

        // Parametresiz (default) constructor.
        // Yeni bir Baby nesnesi oluşturulduğunda, doğum tarihi otomatik olarak "şu anki tarih" olur.
        public Baby()
        {
            DogumTarih = DateTime.Now;  // Varsayılan olarak bugünün tarihi atanır.
            Console.WriteLine("Ingaaa");  // Bebek doğduğunda mesaj yazdırılır.
        }

        // Parametreli constructor: Bebek nesnesi oluşturulurken ad ve soyad bilgisi atanır.
        public Baby(string ad, string soyAd)
        {
            Ad = ad;  // Gelen parametreyi Ad özelliğine atıyoruz.
            SoyAd = soyAd;  // Gelen parametreyi SoyAd özelliğine atıyoruz.
            DogumTarih = DateTime.Now;  // Doğum tarihi bugünün tarihi olarak atanır.

            Console.WriteLine("Ingaaa");  // Yeni bebek için mesaj yazdırılır.
        }
    }
}
