using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using BANKAKKAUNTS.Classes;

string Hisob,
FoydalanuvchiIsmi,
FoydalanuvchiFamiliyasi;
int balans1 = 1000,
balans2 = 500;
Security security = new Security();
Bankservices bankservices= new Bankservices();

key:
Console.Write("\n\t1-HISOB YARATISH");
Console.WriteLine("\t2-HISOBGA KIRISH\n");
Console.Write("Raqamini kiriting!: ");
Hisob = Console.ReadLine();
if (Hisob == "1")
{
    bankservices.HisobYaratish();
}
else if (Hisob == "2")
{
    security.KirishXafsizlik();
}
else
{
    Console.Clear();
    System.Console.WriteLine("Nimadir xato ketti shekili qaytadan urinib koring!");
    goto key;
}

Console.Clear();
bankservices.BankXizmatlari(balans1,balans2);


