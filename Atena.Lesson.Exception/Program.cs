using Exception.Library;
using System;

namespace Atena.Lesson.Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankWebApp ING = new BankWebApp();
           

            try
            {
                ING.Withdraw(10);// --  > esce dal programma
            }
            catch (System.Exception ex )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();         
            }
        } 
    }

    
}