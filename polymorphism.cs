using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace IntrDemo {
    public interface Shape
    {
        void area();
    }
        public class circle : Shape
        {
            public void area()
            {
            Console.WriteLine("------Calculating area of CIRCLE--------");
            Console.Write("Enter the radius : ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle" + (3.142) * r * r);
            }
        }
        public class Square : Shape
        {
            public void area()
            {
            Console.WriteLine("------Calculating area of Square--------");
            Console.Write("Enter the length : ");
            float side = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of square" +(side*side));
        }
     }
        class program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("------Calculating area of Square--------");
            Shape[] s = new Shape[2];
            s[0] = new circle();
            s[1] = new Square();
                for (int i = 0; i < s.Length; i++)
                {
                s[i].area();
                Console.ReadLine();
                }
            }
        }
}
