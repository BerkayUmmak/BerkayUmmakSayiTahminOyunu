using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Gazi.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsminizi giriniz:");
            //string a =Console.ReadLine();
            //Console.WriteLine("Tekrar sayısı:");
            //int c = int.Parse(Console.ReadLine());
            //try
            //{
            //    Console.WriteLine("Başlangıç değeri giriniz:");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Bitiş değeri giriniz:");
            //    int sayi2 = int.Parse(Console.ReadLine());
            //    int t = 0;
            //    Console.WriteLine("Tek-Çift hangi sayıları listeleyelim?");
            //    string a = Console.ReadLine().ToLower();
            //    if (sayi1 > sayi2)
            //    {
            //        int temp = sayi1;
            //        sayi1 = sayi2;
            //        sayi2 = temp;



            //    }
            //    else { }

            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        if (i % 2 == (a == "tek" ? 1 : 0))
            //        {
            //            Console.WriteLine(i);
            //            //t = t + i;
            //            t += i; //daha kısa olduğu için bunu tercih ediyoruz.
            //        }

            //    }
            //    Console.WriteLine($"Aralıktaki sayıların toplamı:{t}");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Gereğinden fazla değer girildi.");


            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Lütfen rakamsal değer giriniz.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bir hata oluştu, lütfen dağıtıcı ile iletişime geçiniz.");
            //}
            // Console.WriteLine("Taban giriniz:");
            // int b =int.Parse(Console.ReadLine());
            // Console.WriteLine("Üs giriniz:");
            //int a= int.Parse(Console.ReadLine());
            // int sonuc = 1;
            // if (b>a)
            // {
            //     int temp = b;
            //     b = a; a= temp;
            // }
            // else { }
            // for (int i = 1; i<=a; i++) 
            // {

            //     sonuc = b*sonuc;




            // }
            // Console.WriteLine($"sonuç={sonuc}");

            // Console.WriteLine("Sayı giriniz:");
            // int sayif =int.Parse(Console.ReadLine());
            // int sonuc = 1;
            //for (int i = 1; i <= sayif; i++)
            // {
            //     sonuc = sonuc * i;
            // }
            // Console.WriteLine($"Sonuç:{sonuc}");



            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.Write("Sayı giriniz: ");
            //int sayi=int.Parse(Console.ReadLine());
            //int sayac = 0;
            //for(int i = 2; i <= (sayi/2); i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break;
            //    }
            //}
            //Console.WriteLine(sayac==0 ? "Asal.":"Asal değil.");
            //Console.ForegroundColor = ConsoleColor.Black;

            //for (;;) 
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz:");
            //    string ad=Console.ReadLine();
            //    Console.WriteLine("Şifre giriniz:");
            //    string sifre=Console.ReadLine();
            //    if ((ad == "admin") && (sifre == "123"))
            //    {
            //        Console.WriteLine("Giriş yaptınız.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Tekrar deneyiniz.");
            //    }


            //}


            // double temp = double.MinValue, toplam = 0, sayac = 0;

            //for (; ; ) 
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    double sayi=double.Parse(Console.ReadLine());

            //    if (sayi > temp)
            //    {
            //        temp = sayi;
            //    }

            //    Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
            //   string cevap = Console.ReadLine().ToUpper();
            //    sayac++;
            //    toplam = toplam+sayi;

            //    if (cevap == "H")
            //    {

            //        break;
            //    }




            //}

            //Console.WriteLine($"Girdiğiniz en büyük sayı: {temp}\nSayıların toplamı={toplam}\nGirilen sayıların ortalamaları:{toplam/sayac}");

            //for (int i = 0; i < 3; i++) 
            //{
            // for(int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j}\t");

            //    }
            //    Console.WriteLine();
            //}


            // for (int i = 1; i <= 5; i++) 
            //{

            // for(int j = 0; j < i; j++)
            //    {

            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)

            //    {
            //        Console.Write((i+j)%2==0? "*":" ");
            //        /*if ((i+j)%2==0)
            //           {
            //              Console.Write("* ");
            //           }
            //          else
            //           {
            //               Console.Write(" ");
            //           }*/
            //    }
            //    Console.WriteLine();

            //}

            //Console.WriteLine("Satır sayısını giriniz:");
            //int satir =int.Parse(Console.ReadLine());
            //Console.WriteLine("Sütun sayısınız giriniz:");
            //int  sutun=int.Parse(Console.ReadLine());
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write((i+j)%2==0? "*":" ");
            //    }
            //    Console.WriteLine();
            //}
            //bool sonuc=false;
            //for (int a = 1; a < 9; a++)
            //{
            //    for (int b = 0; b < 9; b++)
            //    {
            //        for (int c = 1; c < 9; c++)
            //        {
            //            for (int d = 0; d < 9; d++)
            //            {
            //                sonuc = a * 1000 + b * 100 + c * 10 + d == 4 * (d * 1000 + c * 100 + b * 10 + a);
            //                if (sonuc)
            //                {

            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                    break;

            //                }
            //            }
            //            if (sonuc)
            //            {
            //                break;
            //            }

            //        }

            //        if (sonuc) { break; }

            //    }
            // if (sonuc) { break ; }
            //}


            //}

            //for (int a = 1; a <= 100 ; a++)
            //{
            //    for(int b = 1; b <= 100 ; b++)
            //    {
            //        for (int c = 1; c <= 100; c++)
            //        {
            //            if (a * a + b * b == c * c)
            //            {
            //                Console.WriteLine($"{a}-{b}-{c}");
            //            }
            //        }
            //    }
            //}
            //    int a = 0;
            //for (; ; )
            //{
            //    Console.WriteLine("Başlangıç sayısını giriniz:");
            //    a = int.Parse(Console.ReadLine());
            //    if (a >= 2)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("İkiden küçük bir sayı giremezsiniz.");
            //    }

            //}
            //Console.WriteLine("Bitiş sayısını giriniz:");
            //int b = int.Parse(Console.ReadLine());

            //for (int i = a; i <= b; i++)
            //{
            //    int sayac = 0;
            //    for (int j = 2; j <= (i / 2); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(sayac > 0 ? $"{i}-Asal değil" : $"{i}-Asal");

            //}








            //int b = i; b++;
            //Console.WriteLine($"{b++}.{a}");
            //Console.WriteLine(i);

            /* 
              if(a=="çift")
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    t = t + i;
                }
            }
            else if(a=="tek")
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    t= t + i;
                }
            }
            */

            //t = t + i;

            //int count = 0;
            //while (count<5) 
            //{
            // Console.WriteLine("Gazi");
            //    count++;
            //}
            //int sum=0;
            //while (true)
            // {
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Devam etmek ister misiniz? (E/H)");
            //string cevap = Console.ReadLine().ToLower();

            //sum += sayi1;
            //if (cevap == "h")
            //{
            //    break;
            //}

            // }
            // Console.WriteLine(sum);
            //int sum = 0; string cevap;
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Devam etmek ister misiniz? (E/H)");
            //    cevap = Console.ReadLine().ToLower();

            //    sum += sayi1;

            //} while (cevap == "e");
            //Console.WriteLine($"Sayılarınızın toplamı: {sum}");

            //     Sayı Tahmin Oyunu Ödev   //


            int sayac = 100; int minseviye = 1; int max1 = 10; int max2 = 40; int max3 = 100; int max4 = 1000; int lv1 = 10; int lv2 = 20; int lv3 = 50; int lv4 = 100;
            Console.WriteLine("SAYI TAHMİN OYUNUNA HOŞGELDİNİZ.");
            Console.WriteLine("Lütfen seviye seçiniz.(1/2/3/4)");
            int seviye = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int sayi = 0;
            switch (seviye)
            {
                case 1:
                    
                    sayi = rnd.Next(minseviye, max1);
                    break;
                case 2:
                     sayi = rnd.Next(minseviye, max2);
                    break;
                case 3:
                     sayi = rnd.Next(minseviye, max3);
                    break;
                case 4:
                     sayi = rnd.Next(minseviye, max4);
                    break;
            }



            int tahmin;
            do
            {
                Console.WriteLine("Sayı gir:");
                tahmin = int.Parse(Console.ReadLine());

                if (sayi == tahmin)
                {
                    Console.WriteLine("Tebrikler Kazandın.");
                    //Console.ReadKey();
                    //Console.Clear();

                    //Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                    //string cevab=Console.ReadLine();
                    //if (cevab == "E")
                    //{
                    //    Console.WriteLine("Bir sonraki seviyeye geçiliyor.");
                    //    sayi = 0;
                    //}
                    //else { break; }
                }
                else
                {
                    Console.WriteLine("Tekrar dene.");
                    if (seviye == 1)
                    {
                        sayac=sayac-lv1;
                    }
                    else if (seviye == 2)
                    {
                        sayac=sayac-lv2 ;
                    }
                    else if (seviye == 3)
                    {
                        sayac=sayac-lv3;
                    }
                    else { sayac =sayac-lv4; }


                }
                if (sayac == 0)
                {
                    Console.Write("Patladın!!");
                    break;
                }



            } while (sayi != tahmin);
            Console.WriteLine(sayac-10);
            //puanlama sistemi
            //kolay seviyede 5 er 5 er puan azalacak, orta seviyede 10 ar 10 ar, zorda 20şer 20şer,imkansızda 100 can azalacak.
            //sayaç ayarlayacaksın.




        }


    }
}

