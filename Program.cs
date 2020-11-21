using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            B b4 = new B(a3);
            C c6 = new C(b4, a1, a2, a3);
            Console.ReadKey();
        }
    }
    class A 
    {

    }
    class B : A
    {
        protected object a;
        public B(object a)
        {
            this.a = a;
        }
    }
    class C : B
    {
        protected object b, c, d;
        public C(object a, object b, object c, object d):base(a)
        {
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }
}
