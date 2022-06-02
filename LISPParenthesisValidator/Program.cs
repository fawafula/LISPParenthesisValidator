using System;
using System.Collections.Generic;
using System.Linq;

namespace LISPParenthesisValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LISP validator application!");

            var lispCodeIsvalid = ValidateLISPCode(args);

            if (lispCodeIsvalid)
            {

                Console.WriteLine("LISP code paentheses are valid.");
            }
            else
            {
                Console.WriteLine("LISP code parentheses validation failed.");
            }

            Console.WriteLine("Application closed.");

        }

        private static bool ValidateLISPCode(string[] lispCodargs)
        {
            var looongString = string.Join(',', lispCodargs);
           
            var openParenthesesList = looongString.Where(c => c == '(');

            var closeParenthesesList = looongString.Where(c => c == ')');
                     

            if (openParenthesesList.ToList().Count == closeParenthesesList.ToList().Count)
            {
                return true;
            }

            return false;
        }
    }
}
