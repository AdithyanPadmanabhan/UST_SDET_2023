using Basic_Programs.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ExceptionhandlingEX
    {
        public ExceptionhandlingEX(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public void  Divide()
        {
            //try
            //{
                int[] num = { 10, 20, 30 };
               // int res = Number1 / Number2;
               // Console.WriteLine(res);

            for (int i = 0; i <= 3; i++)
            {
                int res = num[i] / Number2;
                Console.WriteLine(res);

            }
            //foreach (var n in num)
            //{
            //   int  res = n/ Number2;
            //    Console.WriteLine(res);

            //}
            // }
            //  catch(ArithmeticException ex)
            //  {
            //      Console.WriteLine("Dont give zero for denomintor");
            //  //    Console.WriteLine(ex.Message);
            //  //    Console.WriteLine(ex.StackTrace);
            //  //    Console.WriteLine(ex.Source);
            //  }
            //  catch (IndexOutOfRangeException ex)
            //  {
            //            Console.WriteLine(ex.Message);
            //  }
            //catch(Exception ex)
            //  {
            //      Console.WriteLine(ex.Message);
            //  }
            // finally {
            //      Console.WriteLine("Done");
            //  }


        }
        public void Numcheck()
        {
            if (Number1 >= 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                // throw new ArgumentException(MyExceptions.excepMeassage[4]);
                throw new Number1Exception(MyExceptions.excepMeassage[4]);
            }
        }
        public void NumcheckTwo()
        {
            if (Number2 < 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
               // throw new ArgumentException(MyExceptions.excepMeassage[5]);
                throw new Number2Exception(MyExceptions.excepMeassage[5]);
            }
        }
        
    }
}
