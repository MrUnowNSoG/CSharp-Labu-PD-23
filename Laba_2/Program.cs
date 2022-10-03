using System;

namespace Laba_2 {
    class Program {
        static void Main(string[] args) {

            //Text Console
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //


            int n = SpecialConsole("Введіть змінну n:");

            double suma = 0;
            for (float i = 0; i < n; i++) {
                double tmp = (Math.Pow(i, 2) - 3) / (Math.Pow(-1, i) * Math.Pow(i, 2) + 5);
                suma += tmp;
            }

            Console.WriteLine($"Результат: {suma}");
        }


        static int SpecialConsole(string text) {

            int tempI = 0;

            Console.Write(text);
            string temp = Console.ReadLine();
            if (int.TryParse(temp, out tempI)) {
                return tempI;
            }

            Console.WriteLine("Error type value");
            return 0;
        }
    }
}
