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

            Console.WriteLine("Application closed.");

        }

        private static void ValidateLISPCode(string[] lispCodargs)
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
    }
}
