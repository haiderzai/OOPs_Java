using System;
namespace Inheritance
{
    class Animal
    {
        public string name;
        public void display()
        {
            Console.WriteLine("I am an animal");

        }
    }
    // derived class
    class Dog: Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is" + name);
        }


    }

    // class to main menue
    class Program
    {
        static void Main(string[] args)
        {
            Dog laborder = new Dog();
            laborder.name="Tazi dog";
            laborder.display();
            laborder.getName();
            Console.ReadLine();
        }
    }
}

