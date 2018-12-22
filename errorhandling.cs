using System;

namespace ErrorHandling
{
    class NestedTry
    {
        int m = 10;
        int n = 0;
        public void Division()
        {
            try
            {
                int k = m / n;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\n Caught an exception in Division method");
                Console.WriteLine("\n" + e);
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("\n Caught an exception in Division method");
                Console.WriteLine("\n" + e);
            }
            finally
            {
                Console.WriteLine("\n Inside Division method finally");
            }
            Console.WriteLine("\n Outside Division method finally");    // Skipped
        }
    }
    class ErrorHandling
    {
        public static void Main()
        {
            NestedTry NT = new NestedTry();
            Console.Clear();
            try
            {
                NT.Division();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\n Array index error");
                Console.WriteLine("\n" + e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n Caught an exception in Main");
                Console.WriteLine("\n" + e);
            }
            Console.Write("\n Inside Main method ");
            Console.ReadLine();
        }
    }

}
