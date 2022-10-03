using System;

namespace Laba_3 {
    class Program {

        static void Main(string[] args) {

            //Text
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Text


            //Variant = 8
            int a = InputVariable("A");
            int b = InputVariable("B");
            int c = InputVariable("C");

            if( (a == -b) || (a == -c) || (b == -c)) {
                Console.WriteLine("True");
                Console.WriteLine("Серед трьох чисел э пара протилежних.");

            } else Console.WriteLine("False");
        }

        static int InputVariable(string name) {

            int GoodVariable = 0;
            string temp;
            do {
                Console.Write($"Введіть змінну {name}:");
                temp = Console.ReadLine();

                Console.WriteLine();
            } while (!int.TryParse(temp, out GoodVariable));

            return GoodVariable;
        }
    }
}
