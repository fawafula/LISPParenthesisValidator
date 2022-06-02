using LISPParenthesisValidator.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISPParenthesisValidator.Domain.Utilities

{
    public class ParenthesisValidator : IParenthesisValidator
    {
        #region Fields
        private string[] _lispCode;
        #endregion

        #region Properties

        #endregion

        #region Constructors
        public ParenthesisValidator(string[] lispCode)
        {
            _lispCode = lispCode;
        }
        #endregion

        #region Methods
        public bool ValidateParentheses() 
        {
            var looongString = string.Join(',', _lispCode);

            var openParenthesesList = looongString.Where(c => c == '(');

            var closeParenthesesList = looongString.Where(c => c == ')');


            if (openParenthesesList.ToList().Count == closeParenthesesList.ToList().Count)
            {
                return true;
            }

            return false;
        }

        #endregion

    }

}
