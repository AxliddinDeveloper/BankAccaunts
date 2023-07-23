using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;


    
string Hisob,
FoydalanuvchiIsmi,
FoydalanuvchiFamiliyasi,
password,
password2,
hohish;
int balans1 = 1000,
balans2 = 500,
toldirish,
otkazish;


key:
Console.Write("\n\t1-HISOB YARATISH");
Console.WriteLine("\t2-HISOBGA KIRISH\n");
Console.Write("Raqamini kiriting!: ");
Hisob = Console.ReadLine();
if (Hisob == "1")
{
    key1:
    Console.Write("Ismingiz: ");
     FoydalanuvchiIsmi = Console.ReadLine();
    Console.Write("Familiyangiz: ");
     FoydalanuvchiFamiliyasi = Console.ReadLine();
    string Passport = " ";
    do
    {

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
    string PlastikKarta;
    string KartaMuddati;
    string Tekshirish;
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
    key2:
     password = "password";
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
else if (Hisob == "2")
{
    key3:
    Console.Write("ismingiz: ");
     FoydalanuvchiIsmi = Console.ReadLine();
    Console.Write("Familiyangiz: ");
     FoydalanuvchiFamiliyasi= Console.ReadLine();
    string Password;
     
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
else
{
    Console.Clear();
    System.Console.WriteLine("Nimadir xato ketti shekili qaytadan urinib koring!");
    goto key;
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
key7:
System.Console.WriteLine("\t---MENU---");
System.Console.WriteLine("1.BALANSNI TEKSHIRISH");
System.Console.WriteLine("2.BALANSNI TOLDIRISH");
System.Console.WriteLine("3.OTKAZMA");
System.Console.WriteLine("4.CHIQISH");
System.Console.WriteLine("Qaysi xizmatdan foydalanmoqchisiz!: ");
var Menu = Console.ReadLine();
Console.Clear();
switch (Menu)
{
    
    case "1":
        key4:
        System.Console.WriteLine("akkauntingizni tanlang");
        System.Console.WriteLine("1. birinchi akkaunt");
        System.Console.WriteLine("2. ikkinchi akkaunt");
        hohish = Console.ReadLine();
        Console.Clear();
        if (hohish == "1")
        {
            System.Console.WriteLine($"Akkauntingizning balansi: {balans1} ₽");
            goto key7;
        }
        else if (hohish == "2")
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
            hohish = Console.ReadLine();
            Console.Clear();
            if (hohish == "1")
            {
                System.Console.Write($"Akkauntingizni qancha miqdorga toldirmoqchisiz?:");
                toldirish = Convert.ToInt32(Console.ReadLine());
                balans1 += toldirish;
                System.Console.WriteLine("Balansingiz toldirildi!");
                goto key7;
            }
            else if (hohish == "2")
            {
                System.Console.Write($"akkauntingizni qancha miqdorga toldirmoqchisiz?:");
                toldirish = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("balansingiz toldirildi!");
                balans2 += toldirish;
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
            hohish = Console.ReadLine();
            Console.Clear();
            if (hohish == "1")
            {
                System.Console.WriteLine($"Qancha miqdorda pul otkazmoqchisiz?");
                otkazish = Convert.ToInt32(Console.ReadLine());
                balans2 -= otkazish;
                balans1 += otkazish;
                System.Console.WriteLine("O\'tkazish muvaffaqiyatli amalga oshirildi!");
                goto key7;
            }
            else if (hohish == "2")
            {
                System.Console.WriteLine($"Qancha miqdorda pul otkazmoqchisiz?");
                otkazish = Convert.ToInt32(Console.ReadLine());
                balans1 -= otkazish;
                balans2 += otkazish;
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

