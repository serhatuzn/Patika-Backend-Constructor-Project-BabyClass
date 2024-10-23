using Constructor_Project__Baby_Class_; 

// Programın başlangıç noktası
class Program
{
    static void Main(string[] args)
    {
        // Yeni bir Baby nesnesi oluşturulur ve parametresiz constructor kullanılır.
        Baby bebek1 = new Baby();
        bebek1.Ad = "Barlas";  // bebek1'in adı atanır.
        bebek1.SoyAd = "Uzun";  // bebek1'in soyadı atanır.

        // Bebek 1'in bilgileri ekrana yazdırılır.
        Console.WriteLine($"Bebeğin adı: {bebek1.Ad}, Soyadı: {bebek1.SoyAd}, Doğum günü: {bebek1.DogumTarih}");

        // Parametreli constructor ile yeni bir Baby nesnesi oluşturulur.
        Baby bebek2 = new Baby("Lina", "Uzun");

        // Bebek 2'nin bilgileri ekrana yazdırılır.
        Console.WriteLine($"Bebeğin adı: {bebek2.Ad}, Soyadı: {bebek2.SoyAd}, Doğum günü: {bebek2.DogumTarih}");
    }
}
