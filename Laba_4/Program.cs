using System;

namespace Laba_4 {
    class Program {
        static void Main(string[] args) {
            //Text
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Text

            //Variant - 29, не дуже зрозумів завдання
            int N = InputVariable("Розмір масиву");
            int K = InputVariable("К");

            int []array = new int[N];

            //
            Console.WriteLine("Заповнити масив автоматично Yes чи No?");

            if("Yes" == Console.ReadLine()) {
                Random rnd = new Random();
                Console.Write(" \nМасив готовий: ");
                for (int i = 0; i < N; i++) {
                    array[i] = rnd.Next(0, 100);
                    Console.Write(array[i] + " ");
                }

            } else {
                Console.WriteLine("\n Введіть свій масив");
                for (int i = 0; i < N; i++) {
                    array[i] = InputVariable(i);
                }
            }
            //


            bool work = false;
            do {
                //Меню
                Console.WriteLine("\n\nЯкий тип заміни зробити:\n \t1 - все що менше K \n \t2 - Все що дорівнює К \n \t3 - Все що більше за К + 1 елемент \n \t4 - Змішана перевірка\n");
                int index = InputVariable("який тип перевірки");
                work = false;

                //Перевірка
                switch (index) {
                    case 1:
                        for (int i = 0; i < N; i++) {
                            if (array[i] < K) {
                                array[i] = 0;
                                continue;
                            }
                        }
                        break;

                    case 2:
                        for (int i = 0; i < N; i++) {
                            if (array[i] == K) {
                                array[i] = 0;
                                continue;
                            }
                        }
                        break;

                    case 3:
                        int zeroElement = array[0];
                        for (int i = 0; i < N; i++) {
                            if (array[i] > K + zeroElement) {
                                array[i] = 0;
                                continue;
                            }
                        }
                        break;

                    case 4:
                        int zeroElemente = array[0];
                        for (int i = 0; i < N; i++) {
                            if (array[i] <= K) {
                                array[i] = 0;
                                continue;
                            }

                            if (array[i] > K + zeroElemente) {
                                array[i] = 0;
                                continue;
                            }
                        }
                        break;

                    default:
                        work = true;
                        break;
                }
            } while (work);
            //


            Console.Write("\nНовий масив готовий: ");
            for (int i = 0; i < N; i++) {
                Console.Write(array[i] + " ");
            }
        }

        static int InputVariable(int index) {

            int GoodVariable = 0;
            string temp;
            do {
                Console.Write($"Введіть {index} eлент масиву:");
                temp = Console.ReadLine();

                Console.WriteLine();
            } while (!int.TryParse(temp, out GoodVariable));

            return GoodVariable;
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
