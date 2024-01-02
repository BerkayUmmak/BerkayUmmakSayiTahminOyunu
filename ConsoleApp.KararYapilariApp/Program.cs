using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

namespace ConsoleApp.KararYapilariApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Dil Seçiniz/Select Language");
            //string dil = Console.ReadLine();

            //string msg1, msg2, msg3, msg4,msg5;
            //if (dil.ToUpper() == "TR")
            //{
            //    msg1 = "Birinci Sayı:";
            //    msg2 = "İkinci Sayı:";
            //    msg3 = "İşlem Seçiniz:";
            //    msg4 = "Hata algılandı, tekrar deneyiniz.";
            //    msg5 = "Sonuç:";
            //}
            //else
            //{
            //    msg1 = "First Number:";
            //    msg2 = "Second Number:";
            //    msg3 = "Select Operation:";
            //    msg4 = "An error occurred, try again.";
            //    msg5 = "Result:";

            //}





            //    Console.WriteLine(msg1);
            //    double s1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine(msg2);
            //    double s2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine(msg3);
            //    char islem = char.Parse(Console.ReadLine());



            //    if (islem == '+')
            //    {
            //        Console.WriteLine($"{msg5} {s1 + s2}");
            //    }
            //    else if (islem == '-')
            //    {
            //        Console.WriteLine($"{msg5} {s1 - s2}");
            //    }
            //    else if (islem == '/')
            //    {
            //        Console.WriteLine($"{msg5}{s1 / s2}");
            //    }
            //    else if (islem == '*')
            //    {
            //        Console.WriteLine($"{msg5}{s1 * s2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine(msg4);

            //    }

            //try
            //{
            //    Console.WriteLine("Hava Nasıl?");
            //    string hava = Console.ReadLine().ToUpper();
            //    string msgiyi = "Hava Kaç Derece?";
            //    string msgkotu = "Çıkma.";
            //    string msgcik = "Çıkabilirsin";

            //    if (hava == "GÜZEL" || hava == "İYİ")
            //    {
            //        Console.WriteLine(msgiyi);
            //        //int ustsınır = 35;
            //        //sbyte altsinir = -10;
            //        sbyte derece = sbyte.Parse(Console.ReadLine());
            //        //if (derece > ustsınır || derece < altsinir)
            //        //{ Console.WriteLine(msgkotu); }
            //        //else
            //        //{ Console.WriteLine(msgcik); }
            //        if (derece < 15)
            //        { Console.WriteLine(msgkotu); }
            //        else if (derece >= 15 && derece < 40)
            //        { Console.WriteLine(msgcik); }
            //        else
            //        { Console.WriteLine(msgkotu); }

            //    }
            //    else if (hava == "KÖTÜ" || hava == "BOK GİBİ")
            //    { Console.WriteLine(msgkotu); }
            //    else
            //    { Console.WriteLine("Dediğiniz anlaşılmadı."); }
            //}
            //catch (OverflowException)
            //{

            //    Console.WriteLine("-128 ile 127 aralığında bir sayı giriniz!");
            //}
            //catch (FormatException)
            //{

            //    Console.WriteLine("Sayısal veri giriniz!");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Bilinmeyen bir hata meydana geldi.");
            //    Console.WriteLine($"Hata Mesajı:{ex.Message}\nTarih:{DateTime.Now}\nDetaylar:{ex.StackTrace}");
            //} Console.ForegroundColor = ConsoleColor.Black;

            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    byte sayi = byte.Parse(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sadece Sayı giriniz!!");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 Arası bir sayı giriniz!!");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen bir hata meydana geldi.");
            Console.WriteLine("Bir sayı giriniz:");
            byte sayi= byte.Parse(Console.ReadLine());
            if (sayi == 1) {
                Console.WriteLine("Bir"); 
            }
            else if (sayi == 2) { 
                Console.WriteLine("İki"); 
            }
            else if (sayi == 3) { 
                Console.WriteLine("üç");
            }
            else {
                Console.WriteLine("Yanlış giriş"); 
            }


            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("iki");
                    break;
                case 3:
                    Console.WriteLine("üç");
                    break;
                    default: Console.WriteLine("Yanlış giriş");
                    break;
                    


            }



        }


            //Dil seçiniz/Select Language :EN
            //Enter fist number :10
            //Enter second number :10
            //Select Operation:+
            //Result:20
        }
    }


    
/* Exception Handling -Hata Yakalama*/
 
