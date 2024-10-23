# **👶 Baby Class Projesi**

Bu proje, bir **bebek sınıfı (Baby)** tanımlayarak **C#'ta sınıf yapısını, constructor'ları ve encapsulation (kapsülleme) ilkesini** öğrenmeye yönelik bir örnektir. Bebeklerin **adı, soyadı ve doğum tarihi** gibi temel bilgilerini tutar ve doğum tarihi üzerinde kontrollü değişiklik yapmayı sağlar. 🎉

---

## **✨ Özellikler**
- **🔒 Kapsülleme (Encapsulation)**: Doğrudan erişim yerine `private` alanlar ve `public` özelliklerle veri güvenliği sağlanır.
- **🎈 Constructor kullanımı**:  
  - **🍼 Parametresiz Constructor**: Doğum tarihi otomatik olarak bugünün tarihi olur.  
  - **🌟 Parametreli Constructor**: Ad ve soyad bilgileri nesne oluşturulurken atanır.
- **📅 Kontrollü veri girişi**: Yanlış doğum tarihi girişlerine karşı uyarı verir.

---

## **🛠️ Kullanılan Teknolojiler**
- **C# 11** 
- **.NET 6+ SDK**  
- Visual Studio veya Visual Studio Code 

---

## **💻 Kod Yapısı**

**1. Baby.cs (Sınıf Tanımı)**  
Bebek sınıfı, ad, soyad ve doğum tarihi bilgilerini içerir.

```csharp
public class Baby
{
    private DateTime _dogumTarih;

    public string Ad { get; set; }
    public string SoyAd { get; set; }

    public DateTime DogumTarih
    {
        get { return _dogumTarih; }
        set
        {
            if (value < DateTime.MinValue)
            {
                Console.WriteLine("❌ Yanlış doğum tarihi girildi.");
                _dogumTarih = DateTime.MinValue;
            }
            else
            {
                _dogumTarih = value;
            }
        }
    }

    public Baby()
    {
        DogumTarih = DateTime.Now;
        Console.WriteLine("🎉 Constructor çalıştı: Parametresiz constructor kullanıldı.");
    }

    public Baby(string ad, string soyAd)
    {
        Ad = ad;
        SoyAd = soyAd;
        DogumTarih = DateTime.Now;
        Console.WriteLine("🎉 Constructor çalıştı: Parametreli constructor kullanıldı.");
    }
}
