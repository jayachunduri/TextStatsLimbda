using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLimbda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("I Love Coding!");
        }

        static void TextStats(string input)
        {
            Console.WriteLine("Original String: " + input);

            Console.WriteLine("Number of Characters: " + input.ToString().Length);

            Console.WriteLine("Number of Words: " +input.Split(' ').Count());

            Console.WriteLine("Number of vowels: " +input.ToLower().Count(x => (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')));

            Console.WriteLine("Number of consonants: " +input.ToLower().Count(x => !(x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u' || x == ' ' || x == '?' || x == '!' || x == '.' || x == ',')));

            Console.WriteLine("Number of special characters: " +input.Count(x => (x==' ' || x == '?' || x == '!' || x == '.' || x == ',')));

            Console.WriteLine("Longest Word: " +input.Split(' ').OrderByDescending(x => x.Length).First());

            Console.WriteLine("Shortest Word: " +input.Split(' ').OrderBy(x => x.Length).First());
        }
    }
}
