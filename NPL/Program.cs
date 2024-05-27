using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText("treasureisland.txt");
            //System.Console.WriteLine(input);
            int[] counts = new int[4];
            
            counts[0] = GetPrintableChar(input);
            counts[1] = GetSpaces(input);
            counts[2] = GetVowels(input);
            counts[3] = GetConsonants(input);
            Console.WriteLine("Printable characters: " + counts[0]);
            Console.WriteLine("Spaces: " + counts[1]);
            Console.WriteLine("Vowels: " + counts[2]);
            Console.WriteLine("Consonants: " + counts[3]);
            GetFrequencyOfVowels(input);
            Console.ReadKey();
        }
        static int GetPrintableChar(string input)
        {
            if (input == null)
            {
                return 0;
            }
            int printable = 0;
            foreach (char c in input)
            {
                if (c >= 32 && c < 127)
                {
                    printable++;
                }
            }
            return printable;
        }
        static int GetSpaces(string input)
        {
            if (input == null)
            {
                return 0;
            }
            int spaces = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaces++;
                }
            }
            return spaces;
        }
        static int GetVowels(string input)
        {
            if (input == null)
            {
                return 0;
            }
            int vowels = 0;
            foreach (char c in input)
            {
                if (c == 'a' | c == 'e' | c == 'i' | c == 'o' | c == 'u' | c == 'A' | c == 'E' | c == 'I' | c == 'O' | c == 'U')
                {
                    vowels++;
                }
            }
            return vowels;

        }
        static int GetConsonants(string input)
        {
            if (input == null)
            {
                return 0;
            }
            char[] notAllowed = { ' ', ',', '.', ':', '\t',';','!','@','#','$','%','^','&','*'
                    ,'(',')','-','_','/','|','[',']','{','}','<','>','?','1','2','3','4','5','6'
                    ,'7','8','9','0','\'','A','E','I','O','U','a','e','i','o','u'};
            int consonants = 0;
            foreach (char c in input)
            {
                if (!notAllowed.Contains(c))
                { 
                    consonants++;
                }
            }
            return consonants;
        }
        static void GetFrequencyOfVowels(string input)
        {
            int vowelA = 0;
            int vowelE = 0;
            int vowelI = 0;
            int vowelO = 0;
            int vowelU = 0;
            foreach (char c in input)
            {
                if (c == 'a' | c == 'A')
                {
                    vowelA++;
                }
                if (c == 'e' | c == 'E')
                {
                    vowelE++;
                }
                if (c == 'i' | c == 'I')
                {
                    vowelI++;
                }
                if (c == 'o' | c == 'O')
                {
                    vowelO++;
                }
                if (c == 'u' | c == 'U')
                {
                    vowelU++;
                }
            }
            Console.WriteLine("Vowel frequency is:");
            Console.WriteLine("A: " + vowelA);
            Console.WriteLine("E: " + vowelE);
            Console.WriteLine("I: " + vowelI);
            Console.WriteLine("O: " + vowelO);
            Console.WriteLine("U: " + vowelU);
        }
    }
}
