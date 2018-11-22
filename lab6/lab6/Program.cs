using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Lab5
{

    class Program
    {
        static void Main(string[] args)
        {
            Person Andrey = new Person(156948, "Andrey", "Cherbikov", "Pr.Miru 43B", 0935948952, false)
            {
                age= 30,
                onhands = "Шерлок Холмс,Буратiно",
                needtoret = "Буратiно"
            };
            Andrey.PrintInfo();
            Person Yuri = new Person(759615, "Yuri", "Merdov", "st.Nikolskaya", 0937628439, true)
            {
                age = 52,
                onhands = "Мобi дiк, Буквар, Сяйво",
                needtoret = ""
            };
            Yuri.PrintInfo();
            Console.ReadKey();
        }
    }
}