using System;
using System.Collections;
using System.Text;
using Domain;

namespace OOP_AccessModifier_Task
{
    class Person : Group
    {
        internal string name;
        private protected  string surname;
        protected string address { get; set; }
        protected internal string Color { get; set; }
        private int age;

        public int Age
        {
            get
            {
                if(age < 18)
                {
                    Console.WriteLine("Can't see!");
                    return -1;
                }
                return age;
            }
            set
            {
                age = value;
            }
        }
         
        public Person(string phone)
        {
            Console.WriteLine(phone);
        }

        public Person()
        {
            surname = "Afandiyev";
        }

        public void ShowSurname()
        {
            Console.WriteLine(surname);
        }


    }

}
