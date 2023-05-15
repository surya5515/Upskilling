using System;

namespace ExceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int div = 0;
            try
            {
                throw new DivideByZeroException("Invalid Division");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exception Occured");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is {div} ");
            }
    }
}