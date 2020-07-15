using System;
using System.Linq;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hyphen separated integers");

            var hyphenNumbers = Console.ReadLine();
            var numberArray = hyphenNumbers.Split("-");

            if(numberArray.Length > numberArray.Distinct().Count())
                Console.WriteLine(false);
            else
                Console.WriteLine(true);

        }
    }
}
