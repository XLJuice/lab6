using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        private int id;
        private string name;
        private string surname;
        public int age;
        private string addres;
        private int telephone;
        private bool allow;
        public string onhands;
        public string needtoret;
        public Person(int ID, string Name, string Surname, string Addres, int Telephone, bool Allow)
        {
            this.id = ID;
            this.name = Name;
            this.surname = Surname;
            this.addres = Addres;
            this.telephone = Telephone;
            this.allow = Allow;

        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 1)
                    age = value;
                else
                    throw new InvalidAgeException();
            }
        }
        public string Onhands
        {
            get { return onhands; }
            set
            {
                onhands = value;
            }
        }
        public string Needtoret
        {
            get { return needtoret; }
            set
            {
                needtoret = value;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про користувача бiблiотеки: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Iм'я: " + name + ' ' + surname);
            Console.WriteLine("Кiлькiсть рокiв: " + age);
            Console.WriteLine("Адресса: " + addres);
            Console.WriteLine("Телефон: +380" + telephone);
            Console.WriteLine("Взятi книги: " + onhands);
            Console.WriteLine("Треба повернути :" + needtoret);
            Console.WriteLine(allow ? "Можна видавати книги" : "Не можна видавати книги");
            Console.WriteLine();
        }
    }
    //public class Old : Person
    //{  
    //    if (year < 60 ){throw new InvalidOldException
    //}
    //public Old(int ID, string Name, string Surname, int Year, string Addres, int Telephone, bool Allow) : base(ID, Name, Surname, Year, Addres, Telephone, Allow) { }

}
public class PersonException : Exception
{
    public PersonException(string messange) : base(messange) { }
}

public class InvalidAgeException : PersonException
{
    public InvalidAgeException() : base("Ви вказали не коректний вік") { }
}
