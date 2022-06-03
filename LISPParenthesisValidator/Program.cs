using LISPParenthesisValidator.Domain.Utilities;
using System;

namespace LISPParenthesisValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LISP validator application!");

            ValidateLISPCode(args);

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
                Console.WriteLine("Press any key to close application.");
                Console.ReadLine();
            }
           
        }
    }
}
