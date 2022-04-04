using System;

namespace Generator{        

    public class LetterGenerator {
        public void randomLetters() {
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