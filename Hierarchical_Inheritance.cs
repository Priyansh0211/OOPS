using System;

namespace LearningInheritance1
{
    class ParentClass1
    {
        public string name;
        public int Id = 10;

        public void displayParentClassDetail()
        {
            Console.WriteLine($"I am {name}");
            Console.WriteLine($"ID : {Id}");
        }
    }

    class ChildClass1 : ParentClass1
    {
        public void getIdFromParentClass()
        {
            Console.WriteLine("From my child class");
            Console.WriteLine($"ID : {Id}");
        }
    }

    class anotherChildClass1 : ParentClass1 
    {
        public void getIdFromParentClass()
        {
            Console.WriteLine("From my anotherchild class");
            Console.WriteLine($"ID : {Id}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            anotherChildClass1 child = new anotherChildClass1();

            child.getIdFromParentClass();
        }
    }
}