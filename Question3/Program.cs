using System;
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string word's");
            var word = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(word))
            {
                var dictionary = new Dictionary<string, int>();
                var result = string.Empty;

                foreach (var ch in word)
                {
                    if (dictionary.ContainsKey(ch.ToString()))
                        dictionary[ch.ToString()]++;
                    else
                        dictionary.Add(ch.ToString(), 1);
                }


                foreach (var i in dictionary)
                    result += i.Key + i.Value;

                Console.WriteLine(result);

            }

            else
                Console.WriteLine("Please enter a valid word");

        }


    }
}
