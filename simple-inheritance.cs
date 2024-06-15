using System;
namespace LearningInheritance
{
    class ParentClass
    {
        public string name;
        public int Id = 9;

        public void displayParentClassDetails()
        {
            Console.WriteLine($"I am {name}");
            Console.WriteLine($"ID : {Id}");
        }
    }

    class ChildClass : ParentClass
    {
        public void getIdFromParentClass()
        {
            Console.WriteLine($"This is mt ID : {Id}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();
            child.name = "Priyansh";
            child.getIdFromParentClass();
        }
    }
}
