using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2.Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            basla:
            Console.WriteLine("Adınızı giriniz...");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz...");
            string soyad = Console.ReadLine();

            string email = ad + "." + soyad + "@mail.com";

            Console.WriteLine($"Sayın {ad} {soyad}, {email} mail adresiniz aktif hale getirilmiştir.");
            Console.WriteLine("Başka bir hesap oluşturmak istiyor musunuz? evet yazınız...");
            string tekrar = Console.ReadLine().ToLower();
            if (tekrar == "evet")
            {
                goto basla;

            }
            else
            {
                Console.WriteLine("Çıkamak için bir tuşa basınız, iyi günler dileriz.");
                Console.ReadKey();
            }
        }
    }
}
