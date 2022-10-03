using System;

namespace Laba_5 {
    class Program {
        static void Main(string[] args) {
            //Text
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Text

            //Variant - 29
            int M = InputVariable("Розмір масиву M");
            int N = InputVariable("Розмір масиву N");

            int[,] array = new int[M,N];

            //
            Console.WriteLine("Заповнити масив автоматично Yes чи No?");

            if ("Yes" == Console.ReadLine()) {

                Random rnd = new Random();
                Console.WriteLine("\nМасив готовий: ");

                for (int i = 0; i < M; i++) {
                    for(int k = 0; k < N; k++) {
                        array[i,k] = rnd.Next(-10, 21);
                        Console.Write(array[i, k] + "  ");
                    }
                    Console.WriteLine();
                }

            } else {
                Console.WriteLine("\n Введіть свій масив");
                for (int i = 0; i < M; i++) {
                    for (int k = 0; k < N; k++) {
                        array[i, k] = InputVariable($"масива, рядок - {i}, стовпчик - {k} ");
                    }
                }

                Console.WriteLine("Масив готовий:");
                for (int i = 0; i < M; i++) {
                    for (int k = 0; k < N; k++) {
                        Console.Write(array[i, k] + "  ");
                    }
                    Console.WriteLine();
                }
            }
            //


            //Перевірки
            bool[] arrayNew = new bool[N];

            for (int i = 0; i < N; i++) {
                bool tryeST = true;
                for (int k = 0; k < M; k++) {
                    if(array[k,i] < 1) {
                        tryeST = false;
                    }
                }
                arrayNew[i] = tryeST;
            }
            //

            Console.WriteLine("\n\n Масив готовий(Одиниці проставлені перед додатнім стовпчиком):");
            for (int i = 0; i < M; i++) {
                for (int k = 0; k < N; k++) {
                    if(arrayNew[k]) {
                        Console.Write(1 + "  ");
                    } 
                    Console.Write(array[i, k] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n Масив готовий(Одиниці проставлені після додатнім стовпчиком):");
            for (int i = 0; i < M; i++) {
                for (int k = 0; k < N; k++) {
                    Console.Write(array[i, k] + "  ");
                    if (arrayNew[k]) {
                        Console.Write(1 + "  ");
                    }
                }
                Console.WriteLine();
            }

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
