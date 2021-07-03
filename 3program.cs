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
            Console.WriteLine(cube(3));

            /* IF STATEMENT */
            bool isMale = false;
            if(isMale) {
                Console.WriteLine("You are male");
            } else {
                Console.WriteLine("You are not male");
            }

            /* SWITCH */
            Console.WriteLine(GetDay(0));

            /* WHILE / FOR LOOPS */
            //same as c++

        }

        /* METHODS */
        static void SayHi(string name) {
            Console.WriteLine("Hello " + name);
        }

        static int cube(int num) {
            int result = num * num * num;
            return result;
        }

        static string GetDay(int dayNum) {
            string dayName;

            switch(dayNum) {
                case 0:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid dayNum";
                    break;
            }

            return dayName;
        }
    }
}