using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class DivNumbers
    {
        int result;
        public DivNumbers()
        {
            result = 0;
        }
        public int Division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception Caught: {0}", e);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught: {0}", ex);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DivNumbers obj = new DivNumbers();
            Console.WriteLine("Result is:" + obj.Division(25, 0));
            Console.ReadKey();
        }
    }
}
