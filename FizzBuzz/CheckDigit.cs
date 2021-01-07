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

        public CheckDigit(int digit)
        {
            _digit = digit;
           

        }
        public string Check()
        {

            if ((_digit % 3)==0 && (_digit % 5) == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
          
            else if ((_digit % 3) == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if ((_digit % 5) == 0)
            {
                Console.WriteLine("Buzz");

            }

            string number = _digit.ToString();
            return number;
        }
    }
}
