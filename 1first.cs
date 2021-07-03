using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Compiling: mcs 1first.cs
    Executing: mono 1first.exe */

namespace Project {
    class Program {
        static void Main(string[] args) {
            
            /* VARIABLES */
            string characterName = "John";
            char grade = 'A';
            int characterAge;
            characterAge = 35;
            int age = -30;
            double gpa = 3.0;
            bool isMale = true;
            int num = 6;
            num++;

            Console.WriteLine("Hello World");
            Console.WriteLine("  /");
            Console.WriteLine(" /");
            Console.WriteLine("/");
            Console.WriteLine(30);
            Console.WriteLine(isMale);

            Console.WriteLine("\nThere once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            /* STRINGS */
            Console.WriteLine("\n" + characterName.Length);
            Console.WriteLine(characterName.ToUpper());
            Console.WriteLine(characterName.ToLower());
            Console.WriteLine(characterName.Contains("Jo"));
            Console.WriteLine(characterName[2]);
            Console.WriteLine(characterName.IndexOf("hn"));
            Console.WriteLine(characterName.IndexOf("z"));
            Console.WriteLine(characterName.Substring(1, 2));

            /* MATH */
            Console.WriteLine(Math.Pow(3, 5));
            Console.WriteLine(Math.Max(4,90));
            Console.WriteLine(Math.Min(4,90));
            Console.WriteLine(Math.Round(5.6243));

            /* INPUT */
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

        }
    }
}