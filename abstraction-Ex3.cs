using System;

namespace ex3
{
    public abstract class A
    {
        public int i = 7;
        public abstract void display();
    }
    class B : A
    {
        public int j;
        public override void display()
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            B obj1 = new B();
            obj.j = 1;
            obj1.i = 8;
            obj.display();
        }
    }
}