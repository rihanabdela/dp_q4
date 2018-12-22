using System;

namespace virtual
{
    class super
    {
        protected int x;
        public super(int x)
        {
            this.x = x;
        }
        public virtual void display()
        {
            Console.WriteLine("\n Super x = " + x);
        }
    }
    class sub : super
    {
        int y;
        public sub(int x, int y) : base(x)
        {
            this.y = y;
        }
        public override void display()
        {
            Console.WriteLine("\n Sub x = " + x);     // OR base.display();
            Console.WriteLine("\n Sub y = " + y);
        }
    }
    class overridetest
    {
        public static void Main()
        {
            sub s = new sub(100, 200);
            s.display();
            Console.ReadLine();
        }
    }
}
