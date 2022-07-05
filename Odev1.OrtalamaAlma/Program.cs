using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1.OrtalamaAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vizeGir:
            Console.WriteLine("Vize notunu giriniz...");
            string girilenVize=Console.ReadLine();
            bool sayiMi1 = double.TryParse(girilenVize, out double vize);
            if (sayiMi1 == false)
            {
                Console.WriteLine("Hatalı giriş!");
                goto vizeGir;
            }
            else if (vize < 0)
            {
                Console.WriteLine("Hatalı giriş!");
                goto vizeGir;
            }

            finalGir:
            Console.WriteLine("Final notunu giriniz...");
            string girilenFinal = Console.ReadLine();
            bool sayiMi2 = double.TryParse(girilenFinal, out double final);
            if (sayiMi2 == false)
            {
                Console.WriteLine("Hatalı giriş!");
                goto finalGir;
            }
            else if (final < 0)
            {
                Console.WriteLine("Hatalı giriş!");
                goto finalGir;
            }
            double ortalama = (vize * 40) / 100 + (final * 60) / 100;
            if(ortalama < 50)
            {
                Console.WriteLine("Ortalama notunuz:"+ ortalama+ ". Kaldınız.");
            }
            else
            {
                Console.WriteLine($"Ortalama notunuz:{ortalama}. Gectiniz.");
            }
            Console.WriteLine("Tekrar Girmek isterseniz e giriniz...");
            string tekrar = Console.ReadLine().ToLower();
            if (tekrar == "e")
            {
                goto vizeGir;
            }
            else
            {
                Console.WriteLine("Başarılar dileriz...");
                Console.ReadKey();
            }


            
        }
    }
}
