using System;

namespace Project {
    class Program {
        static void Main(string[] args) {

            /* ARRAYS */
            int [] luckyNumbers = {4, 5, 2, 6, 4, 12, 463};
            Console.WriteLine(luckyNumbers[3]);
            luckyNumbers[3] = 900;
            Console.WriteLine(luckyNumbers[3]);

            string[] friends = new string[3];
            friends[0] = "Jim";
            friends[1] = "Kelly";

            SayHi("Pat");
        }

        /* METHODS */
        static void SayHi(string name) {
            Console.WriteLine("Hello " + name);
        }
    }
}