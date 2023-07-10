using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giriş_yapma_sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "admin";
            string şifre = "2222";

            Console.WriteLine("Kullanıcı adını girin:");
            string name = Console.ReadLine();

            if (name != isim)
            {
                Console.WriteLine("İsim hatalı");
            }
            else
            {
                Console.WriteLine("İsim onaylandı.Şifre girin:");
                string password = Console.ReadLine();
                if (password != şifre)
                {
                    Console.WriteLine("Şifre hatalı");

                }
                else
                {
                    Console.WriteLine("Giriş başarılı");
                }
            }
            Console.ReadKey();
        }

    }
}
