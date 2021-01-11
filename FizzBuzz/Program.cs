using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj Liczbę");
                var liczba = Console.ReadLine();
                // zmienna do przechowywania długość tekstu
                var length = liczba.Length;

                for (int i = 0; i < length; i++)
                {
                    char[] charFromString = liczba.ToCharArray();
                    if (!char.IsDigit(liczba, i))
                    { }
                }

                var liczbaint = int.Parse(liczba);

                
                var checkdigit = new CheckDigit();
                var number = checkdigit.Check(liczbaint);
           

                
                    Console.WriteLine("");
                    Console.WriteLine(number);
                    Console.WriteLine("Podana liczba nie dzieli się przez 3 i 5 bez reszty");
                                            
            }


            catch (Exception)
            {

                Console.WriteLine("Nie podałeś liczby");
            }



        }
    }
}
