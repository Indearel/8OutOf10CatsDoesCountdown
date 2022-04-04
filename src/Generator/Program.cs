using System;
using System.Collections.Generic;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)

        {
            var randomSmall = new Random();

            for (int j = 0; j < 1; j++);

            Console.WriteLine($"The first small number is {randomSmall.Next(1, 11)}");
            Console.WriteLine($"The second small number is {randomSmall.Next(1, 11)}");
            Console.WriteLine($"The third small number is {randomSmall.Next(1, 11)}");
            Console.WriteLine($"The fourth small number is {randomSmall.Next(1, 11)}");
            Console.WriteLine($"The fifth small number is {randomSmall.Next(1, 11)}");
            Console.WriteLine($"The sixth small number is {randomSmall.Next(1, 11)}");

            var randomBig = new Random();

            string[] firstBiggy = {"25", "50", "75", "100"};
            int firstBigNumber = randomBig.Next(0, firstBiggy.Length);
            Console.WriteLine("The first big number is {0}", (firstBiggy[firstBigNumber]));

            string[] secondBiggy = {"25", "50", "75", "100"};
            int secondBigNumber = randomBig.Next(0, secondBiggy.Length);
            Console.WriteLine("The second big number is {0}", (secondBiggy[secondBigNumber]));

            string[] thirdBiggy = {"25", "50", "75", "100"};
            int thirdBigNumber = randomBig.Next(0, thirdBiggy.Length);
            Console.WriteLine("The third big number is {0}", (thirdBiggy[thirdBigNumber]));

            string[] fourthBiggy = {"25", "50", "75", "100"};
            int fourthBigNumber = randomBig.Next(0, fourthBiggy.Length);
            Console.WriteLine("The fourth big number is {0}", (fourthBiggy[fourthBigNumber]));

            var targetNumber = new Random();

            for (int k = 0; k < 1; k++);

            Console.WriteLine($"The target is {targetNumber.Next(100, 1000)}");

            var randomLetter = new Random();

            string[] firstVowels = {"A", "Ą", "E", "Ę", "I", "O", "Ó", "U", "Y"};
            int firstVowel = randomLetter.Next(0, firstVowels.Length);
            Console.WriteLine("The first big number is {0}", (firstVowels[firstVowel]));

            string[] secondVowels = {"A", "Ą", "E", "Ę", "I", "O", "Ó", "U", "Y"};
            int secondVowel = randomLetter.Next(0, secondVowels.Length);
            Console.WriteLine("The second big number is {0}", (secondVowels[secondVowel]));

            string[] thirdVowels = {"A", "Ą", "E", "Ę", "I", "O", "Ó", "U", "Y"};
            int thirdVowel = randomLetter.Next(0, thirdVowels.Length);
            Console.WriteLine("The third big number is {0}", (thirdVowels[thirdVowel]));

            string[] fourthVowels = {"A", "Ą", "E", "Ę", "I", "O", "Ó", "U", "Y"};
            int fourthVowel = randomLetter.Next(0, fourthVowels.Length);
            Console.WriteLine("The fourth big number is {0}", (fourthVowels[fourthVowel]));

            string[] fifthVowels = {"A", "Ą", "E", "Ę", "I", "O", "Ó", "U", "Y"};
            int fifthVowel = randomLetter.Next(0, fifthVowels.Length);
            Console.WriteLine("The second big number is {0}", (fifthVowels[fifthVowel]));

            string[] firstConsonants = {"B", "C", "Ć", "D", "F", "G", "H", "J", "K", "L", "Ł", "M", "N", "Ń", "P", "R", "S", "Ś", "T", "W", "Z", "Ź", "Ż",};
            int firstConsonant  = randomLetter.Next(0, firstConsonants .Length);
            Console.WriteLine("The first big number is {0}", (firstConsonants[firstConsonant]));

            string[] secondConsonants = {"B", "C", "Ć", "D", "F", "G", "H", "J", "K", "L", "Ł", "M", "N", "Ń", "P", "R", "S", "Ś", "T", "W", "Z", "Ź", "Ż",};
            int secondConsonant  = randomLetter.Next(0, secondConsonants .Length);
            Console.WriteLine("The first big number is {0}", (secondConsonants[secondConsonant]));

            string[] thirdConsonants = {"B", "C", "Ć", "D", "F", "G", "H", "J", "K", "L", "Ł", "M", "N", "Ń", "P", "R", "S", "Ś", "T", "W", "Z", "Ź", "Ż",};
            int thirdConsonant  = randomLetter.Next(0, thirdConsonants .Length);
            Console.WriteLine("The first big number is {0}", (thirdConsonants[thirdConsonant]));
            
            string[] fourthConsonants = {"B", "C", "Ć", "D", "F", "G", "H", "J", "K", "L", "Ł", "M", "N", "Ń", "P", "R", "S", "Ś", "T", "W", "Z", "Ź", "Ż",};
            int fourthConsonant  = randomLetter.Next(0, fourthConsonants .Length);
            Console.WriteLine("The first big number is {0}", (fourthConsonants[fourthConsonant]));

            string[] fifthConsonants = {"B", "C", "Ć", "D", "F", "G", "H", "J", "K", "L", "Ł", "M", "N", "Ń", "P", "R", "S", "Ś", "T", "W", "Z", "Ź", "Ż",};
            int fifthConsonant  = randomLetter.Next(0, fifthConsonants .Length);
            Console.WriteLine("The first big number is {0}", (fifthConsonants[fifthConsonant]));
        }
    }
}