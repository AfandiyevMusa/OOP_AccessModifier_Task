using System;
using Domain;
using OOP_AccessModifier_Task.models;

namespace OOP_AccessModifier_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Task_1
            //Employee employee1 = new Employee();
            //employee1.age = 33;
            //Console.WriteLine(employee1.age);

            //Person person1 = new Person();
            //Console.WriteLine(person1.age);

            ////Task_2
            //Dog dog1 = new Dog("Rex");
            //Console.WriteLine(dog1.name);

            //Dog dog2 = new Dog("Jack");
            //Console.WriteLine(dog2.name);

            //Task_3
            //Employee employee1 = new Employee("0504198914");
            //Person person1 = new Person("0504198914");

            //Task_4
            //Person person1 = new Person();
            //person1.ShowSurname();

            ////Task_5

            //Person person = new Person();
            //person.Age = 17;
            //Console.WriteLine(person.Age);

            ////Task_6
            //Hello hello1 = new Hello();
            //hello1.name;

            //Task_7
            Group group = new Group();
            group.Name = "hello";
            Console.WriteLine(group.Name);
            
        }
    }
}

