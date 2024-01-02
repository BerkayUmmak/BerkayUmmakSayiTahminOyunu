namespace Gazi.HelloWorldApp
{
    internal class Program
    {
        static int sayi = 50;
        static void Main(string[] args)
        {
            //byte a;
            //a = 30;
            //byte b = 40;
            //Console.WriteLine(a + b);

            //byte z, q;
            //z = 40; q = 90;

            //const int number = 100;
            //Console.WriteLine(number);
            //number = 40; //Hata almasının sebebi sabit (const) değişkenlerde sonradan veri değiştirilemez.

            //Console.WriteLine(number);
            //const int da; // const değişkeninde sonradan ekleme yapılmadığından bu örnek yanlıştır.
            //da = 10;

            //byte s1 = 50;
            //short s2 = 50;
            //int s3 = 50;
            //long s4 = 50;

            //Int16 s5 = 50;
            //Int32 s6 = 50;
            //Int64 s7 = 50;

            //float f= 3.12f; veya float f= 3.12F; şeklinde yazılmalıdır.
            //double a = 3.12; yada double a =3.12D; şeklinde yazılabilir.(64 bitlik)
            //decimal a = 3.12m; yada decimal a = 3.12M; şeklinde yazılabilir. (128 bitlik)

            // bool veri tipi: Doğru veya yanlış değerlerini saklamak için  kullanılır. (Genellikle karşılaştırma işlemlerinde başvurulur.)
            // char: tek bir karakter ataması yapmak için kullanılır. char c='A'; şeklinde yazılabilir.
            //string: metinsel verileri saklamak için kullanılır. string isim= "Ahmet" şeklinde yazılabilir.

            //string isim = "Berkay";
            //string soyisim = "Ummak";
            //Console.WriteLine("Merhaba "+isim+" "+soyisim);
            //Console.WriteLine("Merhaba {0} {1}",isim,soyisim);
            //Console.WriteLine($"Merhaba {isim} {soyisim}");

            //Kullanıcılardan Veri Alma//
            
            Console.WriteLine("İsminizi Giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
           string soyad = Console.ReadLine();
            Console.WriteLine($"Hoşgeldin {isim} {soyad}");
            Console.ForegroundColor = ConsoleColor.Black;

            //Console.WriteLine("Bakiye");
            //double bakiye = 5000;
            //bakiye += 1000;
            //Console.WriteLine(bakiye);

            //int sayi1 = 10;
            //int sayi2 = 20;
            //string sonuc= sayi2>sayi1 ? "Sayı 2 büyüktür":"Sayı 1 büyüktür yada sayılar eşittir" ;
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Isminizi Giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Soyisminizi Giriniz:");
            //string soyisim = Console.ReadLine();
            //Console.WriteLine("Yaşınızı giriniz:");
            //byte yas = byte.Parse(Console.ReadLine());
            //Console.WriteLine($"İsminiz: {isim}");
            //Console.WriteLine($"Soyisminiz: {soyisim}");
            //Console.WriteLine($"Yaşınız: {yas}");


            //Console.WriteLine("Birinci Sayıyı Giriniz:");
            //int sayi1=int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci Sayıyı Giriniz:");
            //int sayi2=int.Parse(Console.ReadLine());
            //int sonuc = sayi1 + sayi2; 
            //Console.WriteLine ($"Sayıların toplamı: {sonuc}");



            //**Operatörler**\\
            /*0 && 0 = 0
            //0 && 1 = 0
            1 && 0 = 0
            1 && 1 = 1

            0 || 0 =0
            0 || 1 = 1
            1 || 0 = 1
            1 || 1 = 1
            */

            //**TÜR DÖNÜŞÜMLERİ (TYPE CASTING)**\\
            //byte sayi = 20;
            //int number = sayi; // Implicit Type Casting

            //checked
            //{
            //    int sayi = 25;
            //    byte number = (byte)sayi; // Explicit Type Casting
            //    Console.WriteLine(number); 
            //}
            //büyük tür --> küçük tür RISK:Değer kaybı

            //string--> değer türlerine

            //string sayi = "25";
            ////byte number = Convert.ToByte(sayi);
            //int number=int.Parse(sayi);
            //byte humber= byte.Parse(sayi);
            //Console.WriteLine(number + humber);


        }
    }
}

/* Namespace: İçinde classları bulunduran yapılardır.
{}: Blok yapıları(Scope)
 Class: İçinde metodları bulunduran yapılardır.
 Metod: İş yapan kod bloklarıdır.
Main: Metodu konsol uygulamalarının giriş noktasıdır.(Bulunması zorunludur!)
Syntax: Kod yazım kuralları.
Build->Derleme(Compile): Programlama dilini makina diline çevirir.
 ctrl+k+c :seçili olan şeyleri yoruma çevirir.
 ctrl+k+u : yorum olanı normale çevirir.
 Solution: İçinde birden fazla proje bulundurabilen yapılara denir.
 ctrl+b : Programı derler.
MS-IL : Microsoft Intermedite Language
C#->Build->MS-IL(exe)->Runtime->JIT Compiler->Binary
Runtime: Çalışma Zamanı / .Net Core->Core Common Language Runtime
JIT: Just In Time
Compiler: Derleyici
Compile: Derleme

.NET: Microsoft  tarafından yazılım geliştirmek için tasarlanan bir framework. İçinde programlama dilleri,editörler,derleyiciler,kütüphaneler bulunur.
- Programa Dilleri- C#-Visual Basic-F#
- Editör: Visual Studio-Visual Studio Code
- Kütüphaneler(Library): İçinde classlar bulunur.
- Derleyiciler: Kodları makina dillerine çevirmek için gerekli yazılımlar.


- Desktop(Masaüstü)
- Web Based Software
- Mobile Application (Android-iOS) Xamarin ile
- Game Software (Unity ile)
- iOT: Internet of Things (Akıllı cihazlar için yazılımlar)
- AI

Cross Platform: Windows, MacOs, Linux işletim sistemlerinde çalışabilen uygulamalar.

.NET Framework: Windows
.NET Core: Cross Platform

//** Değişkenler **\\
- Aynı türden değişkenler tek satırda tanımlanabilirler.
- Static değişkenler, program çalıştığı sürece bellekte kalırlar. 
- Değer tanımlanmamış değişkenler kullanılamaz.
-Bit: 0-1
8 Bit = 1 Byte
1024 Byte = 1 Kilo Byte (KB)
1024 Kilobyte = 1 Mega Byte (MB)
1024 MB = 1 Giga Byte (GB)
1024 GB = 1 Tera Byte (TB)


Binary: 2'li sayı sistemi.
Decimal: 10'lu sayı sistemi.

*/
