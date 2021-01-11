using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class CheckDigit
    {
        private int _digit;
       
        public CheckDigit()
        {
           

        }
        public string Check(int digit)
        {
            string number;
            _digit = digit;

            if (_digit % 3 == 0 && _digit % 5 == 0)
            {
                 return "FizzBuzz"; 
            }

            else if (_digit % 3 == 0)
            {
                return "Fizz";
            }
            else if (_digit % 5 == 0)
            {
                return "Buzz";

            }
            else if (_digit % 3 != 0 && _digit % 5 != 0)
            {
                
               return number = _digit.ToString();
            }

        }
        
    }
}
