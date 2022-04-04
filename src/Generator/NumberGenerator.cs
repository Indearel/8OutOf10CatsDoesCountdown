using System;

namespace Generator {
    public class NumberGenerator {

        public void randomNumbers() {
            var randomSmall = new Random();

            for (int j = 0; j < 1; j++);

            Console.WriteLine($"The first small number is {randomSmall.Next(1, 11)}");
            Console.WriteLine($"The second small number is {randomSmall.Next(1, 11)}");
            Console.WriteLine($"The third small number is {randomSmall.Next(1, 11)}");
            Console.WriteLine($"The fourth small number is {randomSmall.Next(1, 11)}");
            // Console.WriteLine($"The fifth small number is {randomSmall.Next(1, 11)}");
            // Console.WriteLine($"The sixth small number is {randomSmall.Next(1, 11)}");

            var randomBig = new Random();

            string[] firstBiggy = {"25", "50", "75", "100"};
            int firstBigNumber = randomBig.Next(0, firstBiggy.Length);

            string[] secondBiggy = {"25", "50", "75", "100"};
            int secondBigNumber = randomBig.Next(0, secondBiggy.Length);

            string[] thirdBiggy = {"25", "50", "75", "100"};
            int thirdBigNumber = randomBig.Next(0, thirdBiggy.Length);

            string[] fourthBiggy = {"25", "50", "75", "100"};
            int fourthBigNumber = randomBig.Next(0, fourthBiggy.Length);
            
            Console.WriteLine("The first big number is {0}", (firstBiggy[firstBigNumber]));
            Console.WriteLine("The second big number is {0}", (secondBiggy[secondBigNumber]));
            // Console.WriteLine("The third big number is {0}", (thirdBiggy[thirdBigNumber]));
            // Console.WriteLine("The fourth big number is {0}", (fourthBiggy[fourthBigNumber]));

            var targetNumber = new Random();

            for (int k = 0; k < 1; k++);

            Console.WriteLine($"The target is {targetNumber.Next(100, 1000)}");
        }
    }
}
