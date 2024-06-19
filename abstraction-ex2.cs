using System;
namespace ex2
{
    abstract class A 
    {
        public int i;
        public int j;
        public abstract void display();
    }

    class B : A
    {
        public int j = 5;
        public override void display()
        {
            this.j = 3;
            Console.WriteLine(i+" : "+j);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.i = 1;
            obj.display();
        }
    }
}