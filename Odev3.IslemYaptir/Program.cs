using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.IslemYaptir
{
    internal class Program
    {
        static void Main(string[] args)
        {
        sayi1Gir:
            Console.WriteLine("1. sayıyı giriniz...");
            string girilenSayi1 = Console.ReadLine();
            if(!float.TryParse(girilenSayi1 , out float sayi1))
            {
                Console.WriteLine("Hatalı giriş!");
                goto sayi1Gir;
            }

        sayi2Gir:
            Console.WriteLine("2. sayıyı giriniz...");
            string girilenSayi2 = Console.ReadLine();
            if (!float.TryParse(girilenSayi2, out float sayi2))
            {
                Console.WriteLine("Hatalı giriş!");
                goto sayi2Gir;
            }

        islemGir:
            Console.WriteLine("İşlem tipi seçiniz.(Toplama için T, Çıkarma için C, Çarpma için X, Bölme için B, Mod Alma için M, Üs Alma için U");
            char islemTipi = Convert.ToChar(Console.ReadLine().ToLower());

            double sonuc = 1f;

            if(islemTipi == 't')
            {
                sonuc = sayi1 + sayi2;
            }
            else if(islemTipi == 'c')
            {
                sonuc = sayi1 - sayi2;
            }
            else if(islemTipi == 'x')
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islemTipi == 'b')
            {
                if (sayi2 == 0f)
                {
                bolmeHata:
                    Console.WriteLine("Hatalı Giriş! işlemi değiştirmek için i, 2. sayıyı değiştirmek için s giriniz...");
                    string sifirHatasi = Console.ReadLine().ToLower();
                    if (sifirHatasi == "i")
                    {
                        goto islemGir;
                    }
                    else if (sifirHatasi == "s")
                    {
                        goto sayi2Gir;
                    }
                    else
                    {
                        goto bolmeHata;
                    }
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }
            }
            else if(islemTipi == 'm')
            {
                if (sayi2 == 0f)
                {
                    modHata:
                    Console.WriteLine("Hatalı Giriş! işlemi değiştirmek için i, 2. sayıyı değiştirmek için s giriniz...");
                    string sifirHatasi = Console.ReadLine().ToLower();
                    if(sifirHatasi == "i")
                    {
                        goto islemGir;
                    }
                    else if(sifirHatasi == "s")
                    {
                        goto sayi2Gir;
                    }
                    else
                    {
                        goto modHata;
                    }
                    
                }
                else
                {
                    sonuc = sayi1 % sayi2;
                }
            }
            else if (islemTipi == 'u')
            {
                sonuc = Math.Pow(sayi1, sayi2);

            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
                goto islemGir;
            }

            Console.WriteLine("İşlemin sonucu:"+sonuc);
            Console.WriteLine("Tekrar işlem yapmak için evet yazınızı...");
            string tekrar = Console.ReadLine().ToLower();
            if (tekrar == "evet")
            {
                goto sayi1Gir;

            }
            else
            {
                Console.WriteLine("Çıkmak için bir tuşa basınız...");
                Console.ReadKey();
            }


            
        }
    }
}
