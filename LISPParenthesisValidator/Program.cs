using LISPParenthesisValidator.Domain.Utilities;
using System;

namespace LISPParenthesisValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LISP validator application!");

            if (args != null && args.Length > 0 )
            {
                ValidateLISPCode(args);
            }
            else
            {
                Console.WriteLine("Please provide some LISP code to evaluate.");
            }

           

            Console.WriteLine("Press any key to close application.");
            Console.ReadLine();

            Console.WriteLine("Application closed.");

        }

        private static void ValidateLISPCode(string[] lispCodargs)
        {
            try
            {
                var validator = new ParenthesisValidator(lispCodargs);

                var parenthesesAreValid = validator.ValidateParentheses();

                if (parenthesesAreValid)
                {

                    Console.WriteLine("LISP code parentheses are valid.");
                }
                else
                {
                    Console.WriteLine("LISP code parentheses validation failed.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
           
        }
    }
}
