using System;
using System.Data.Common;

namespace mulinheritance
{
    class Cat
    {
        public void printcat()
        {
            Console.WriteLine("Cat has four leg");
        }
    }

    class Loin : Cat
    {
        public void printLoin()
        {
            Console.WriteLine("Loin has four leg");
        }
    }

    class dog : Loin
    {
        public void printdog()
        {
            Console.WriteLine("Dog has four leg");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            dog dog = new dog();    

            dog.printdog();
            dog.printLoin();
            dog.printcat();
        }
    }

}