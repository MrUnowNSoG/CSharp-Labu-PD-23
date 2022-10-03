using System;

namespace All_Laba_CSharp {
    class Program {
        static void Main(string[] args) {
            //Text Console
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //


            int U = 0, R = 0;

            U = SpecialConsole("Введіть напругу: ");
            R = SpecialConsole("Введіть опір: ");

            Console.WriteLine($"Сила струму = {U / (R * 1.0)}");

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
