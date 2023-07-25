using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKAKKAUNTS.Classes
{
    public class Bankservices
    {
        private int Toldirish { get; set; }
        private int Otkazish { get; set; }
        private string Hohish { get; set; }
        private string FoydalanuvchiFamiliyasi { get; set; }
        private string FoydalanuvchiIsmi { get; set; }
        private string PlastikKarta { get; set; }
        private string KartaMuddati { get; set; }
        private string Tekshirish { get; set; }




        Security security= new Security();

        public Bankservices()
        {

        }
        public void HisobYaratish()
        {
            key1:
            string Passport;
            do
            {
                Console.Write("Ismingiz: ");
                FoydalanuvchiIsmi = Console.ReadLine();
                Console.Write("Familiyangiz: ");
                FoydalanuvchiFamiliyasi = Console.ReadLine();
                Console.Write("Passport raqamingiz:");
                Passport = Console.ReadLine();
                Console.Clear();
                if (Passport.Length != 8)
                {
                    Console.Clear();
                    Console.WriteLine("Passport  raqamingiz notog'ri iltimos qayta urinib koring!");
                }
            }
            while (Passport.Length != 8);
            {

            }
            do
            {

                Console.Write("Plastik Karta raqamingiz: ");
                PlastikKarta = Console.ReadLine();
                Console.Write("Saqlash muddati: ");
                KartaMuddati = Console.ReadLine();
                if (PlastikKarta.Length != 16)
                {
                    Console.Clear();
                    Console.WriteLine("Karta  raqamingiz notog'ri iltimos qayta urinib koring!");
                }
            }
            while (PlastikKarta.Length != 16);
            {
                Console.Clear();
            }
            security.Xafsizlik();
            Console.WriteLine($"Xush kelibsiz {FoydalanuvchiIsmi} {FoydalanuvchiFamiliyasi}");
            Console.WriteLine("Sizning ma\'lumotlaringiz!\n");
            Console.WriteLine($"Ismingiz: {FoydalanuvchiIsmi} \t Familiyangiz: {FoydalanuvchiFamiliyasi}\n");
            Console.WriteLine($"Karta raqamingiz: {PlastikKarta} \t Saqlash muddati: {KartaMuddati}\n");
            Console.WriteLine($"Pasport raqamingiz: {Passport}\n");
            Console.Write("Malumotlaringiz tog\'ri ekanligiga aminmisiz?(ha/yoq): ");
            Tekshirish = Console.ReadLine();
            if (Tekshirish != "ha")
            {

                Console.WriteLine("Malumotlaringizni Qayta Kiriting!");
                Console.Clear();
                goto key1;
            }
            System.Console.WriteLine("\nSIZNING MALUMOTLARINGIZ MUVAFFAQIYATLI  O\'TDI TABRIKLAYMIZ! \n\n");
        }
        public void BankXizmatlari(int balans1,int balans2)
        {
            
            key7:
            System.Console.WriteLine("\t--- MENU ---");
            System.Console.WriteLine("1.BALANSNI TEKSHIRISH");
            System.Console.WriteLine("2.BALANSNI TOLDIRISH");
            System.Console.WriteLine("3.OTKAZMA");
            System.Console.WriteLine("4.CHIQISH");
            System.Console.Write("Qaysi xizmatdan foydalanmoqchisiz!: ");
            var Menu = Console.ReadLine();
            Console.Clear();
            switch (Menu)
            {
                
                case "1":
                    key4:
                    System.Console.WriteLine("akkauntingizni tanlang");
                    System.Console.WriteLine("1. birinchi akkaunt");
                    System.Console.WriteLine("2. ikkinchi akkaunt");
                    Hohish = Console.ReadLine();
                    Console.Clear();
                    if (Hohish == "1")
                    {
                        System.Console.WriteLine($"Akkauntingizning balansi: {balans1} ₽");
                        goto key7;
                    }
                    else if (Hohish == "2")
                    {
                        System.Console.WriteLine($"Akkauntingizning balansi: {balans2} ₽");
                        goto key7;
                    }
                    else
                    {
                        System.Console.WriteLine("Nimadir xato ketti shekilli qaytadan urinib koring!");
                        goto key4;
                    }
                    break;

                    case "2":
                        key5:
                        System.Console.WriteLine("Akkauntingizni tanlang!");
                        System.Console.WriteLine("1. Birinchi akkaunt");
                        System.Console.WriteLine("2. Ikkinchi akkaunt");
                        Hohish = Console.ReadLine();
                        Console.Clear();
                        if (Hohish == "1")
                        {
                            System.Console.Write($"Akkauntingizni qancha miqdorga toldirmoqchisiz?:");
                            Toldirish = Convert.ToInt32(Console.ReadLine());
                            balans1 += Toldirish;
                            System.Console.WriteLine("Balansingiz toldirildi!");
                            goto key7;
                        }
                        else if (Hohish == "2")
                        {
                            System.Console.Write($"akkauntingizni qancha miqdorga toldirmoqchisiz?:");
                            Toldirish = Convert.ToInt32(Console.ReadLine());
                            System.Console.WriteLine("balansingiz toldirildi!");
                            balans2 += Toldirish;
                            goto key7;
                        }
                        else
                        {
                            System.Console.WriteLine("nimadir xato ketti shekilli qaytadan urinib koring!");
                            goto key5;
                        }
                        break;

                    case "3":
                        key6:
                        System.Console.WriteLine("Qaysi akkauntingizga otkazmoqchisiz?");
                        System.Console.WriteLine($"1.Birinchi akkaunt");
                        System.Console.WriteLine($"2.Ikkinchi akkaunt");
                        Hohish = Console.ReadLine();
                        Console.Clear();
                        if (Hohish == "1")
                        {
                            System.Console.WriteLine($"Qancha miqdorda pul otkazmoqchisiz?");
                            Otkazish = Convert.ToInt32(Console.ReadLine());
                            balans2 -= Otkazish;
                            balans1 += Otkazish;
                            System.Console.WriteLine("O\'tkazish muvaffaqiyatli amalga oshirildi!");
                            goto key7;
                        }
                        else if (Hohish == "2")
                        {
                            System.Console.WriteLine($"Qancha miqdorda pul otkazmoqchisiz?");
                            Otkazish = Convert.ToInt32(Console.ReadLine());
                            balans1 -= Otkazish;
                            balans2 += Otkazish;
                            System.Console.WriteLine("O\'tkazish muvaffaqiyatli amalga oshirildi!");
                            goto key7;
                        }
                        else
                        {
                            System.Console.WriteLine("Nimadir xato ketti shekilli qaytadan urinib koring!");
                            goto key6;
                        }
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Xizmatimizdan foydalangaingiz uchun rahmat!");
                        break;
                }
        }

    }
}