using System;
namespace ex1
{
    abstract class A
    {
        int i;
        public abstract void display();
    }

    class B : A
    {
        public int j;
        public override void display()
        {
            Console.WriteLine(j);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.j = 2;
            obj.display();
        }
    }
}