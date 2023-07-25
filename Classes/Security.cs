using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BANKAKKAUNTS.Classes
{
    public class Security
    {
        public Security()
        {
        
        }
        public void Xafsizlik()
        {
            key2:
            string password = "password",
            password2;
            Console.Write("Parolingizni kiriting!: ");
            password = Console.ReadLine();
            Console.Write("Parolni qayta kiriting!: ");
            password2 = Console.ReadLine();
            Console.Clear();
            if (password != password2)
            {

                Console.WriteLine("Qayta kiritishda xatolik boldi. Qaytadan urinib koring!");
                goto key2;
            }
        }
        public void KirishXafsizlik()
            {
                string Password,
                password2,
                FoydalanuvchiIsmi,
                FoydalanuvchiFamiliyasi;
                key3:
                Console.Write("ismingiz: ");
                FoydalanuvchiIsmi = Console.ReadLine();
                Console.Write("Familiyangiz: ");
                FoydalanuvchiFamiliyasi= Console.ReadLine();
                key4:
                Console.Write("parolingiz: ");
                Password = Console.ReadLine();
                Console.Write("parolingizni qayta kiriting!: ");
                password2 = Console.ReadLine();
                if (Password != password2)
                {
                    Console.WriteLine("Parolni qayta kiritishda xatolik boldi. Qaytadan urinib koring!");
                    Console.Clear();
                    goto key4;
                }
                if ( Password != "password")
                {
                    Console.Clear();
                    System.Console.WriteLine("Hisobga kirishda xatolik yuz berdi qayta urinib koring!");
                    goto key3;
                }
                System.Console.WriteLine("Hisobga kirish muvaffaqiyatli boldi davom etishingiz mumkin!");
            }
    }
}