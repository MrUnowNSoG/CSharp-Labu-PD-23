using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba_6 {
    class Program {
        static void Main(string[] args) {

            //Text
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Text



            //5.1
            ReversMain(InputVariable("яку хочете перевернути"));

            //5.2
            Console.Write("Введіть рядок для поворота:");
            ReversMain(Console.ReadLine());

            //5.3
            ReversMain(InputVariableDouble("яку хочете перевернути(дробову)"));

            //5.4
            Console.Write("Введіть рядок для поворота:");
            string str = Console.ReadLine();
            Console.Write("Введіть магічний знак: ");
            ReversMain(str, Console.ReadLine());

            //6.1
            RecursionMain(InputVariable("яку хочете перевернути"));

            //6.2
            Console.Write("Введіть рядок для поворота:");
            RecursionMain(Console.ReadLine());

            //6.3
            RecursionMain(InputVariableDouble("яку хочете перевернути(дробову)"));

            //6.4
            Console.Write("Введіть рядок для поворота:");
            string strSecond = Console.ReadLine();
            Console.Write("Введіть магічний знак: ");
            RecursionMain(strSecond, Console.ReadLine());

            //7.1
            List<int> listOut;
            OutMetod(out listOut);
            Console.Write("Обернений: ");
            foreach (var i in listOut) {
                Console.Write(i + " "); 
            }

            Console.WriteLine();
            
            //7.2
            List<int> listRef = new List<int>();
            RefMetod(ref listRef);
            Console.Write("Обернений: ");
            foreach (var i in listRef) {
                Console.Write(i + " ");
            }
        }

        static int InputVariable(string name) {

            int GoodVariable = 0;
            string temp;
            do {
                Console.Write($"Введіть змінну {name}:");
                temp = Console.ReadLine();

            } while (!int.TryParse(temp, out GoodVariable));

            return GoodVariable;
        }

        static double InputVariableDouble(string name) {

            double GoodVariable = 0;
            string temp;
            do {
                Console.Write($"Введіть змінну {name}:");
                temp = Console.ReadLine();
            } while (!double.TryParse(temp, out GoodVariable));

            return GoodVariable;
        }


        //5
        static void ReversMain(int indx) {
            string str = indx.ToString();
            for (int i = str.Length - 1; i >= 0; i--) {
                Console.Write(str[i]);
            }

            Console.WriteLine();
        }

        static void ReversMain(string str) {
            for (int i = str.Length - 1; i >= 0; i--) {
                Console.Write(str[i]);
            }

            Console.WriteLine();
        }

        static void ReversMain(double indx) {

            int index = -1;
            bool good = false;

            string str = indx.ToString();

            //Find
            for (int i = 0; i < str.Length; i++) {
                good = false;
                for(int k = 0; k < 10;k++) {
                    string tempStr = k.ToString();
                    if(str[i] == tempStr[0]) {
                        good = true;
                        break;
                    }
                }
                if(!good) {
                    index = i;
                    break;
                }
            }
            //

            if(index == -1) {
                for (int i = str.Length - 1; i >= 0; i--) {
                    Console.Write(str[i]);
                }
            } else {
                for (int i = index - 1; i >= 0; i--) {
                    Console.Write(str[i]);
                }

                Console.Write(str[index]);

                for (int i = str.Length - 1; i > index; i--) {
                    Console.Write(str[i]);
                }
            }

            Console.WriteLine();
        }

        static void ReversMain(string indx, string magicSymbol) {
            string[] str = indx.Split(magicSymbol);

            for (int i = 0; i < str.Length; i++) {
                string tempStr = str[i];
                for(int k = tempStr.Length - 1; k >= 0; k--) {
                    Console.Write(tempStr[k]);
                }

                if (str.Length > 1) {
                    Console.Write(magicSymbol);
                }
            }

            Console.WriteLine();
        }


        //6
        static void RecursionMain(int indx) {
            string str = indx.ToString();
            Recursion(str, 0);

            Console.WriteLine();
        }

        static void RecursionMain(string str) {
            Recursion(str, 0);
            Console.WriteLine();
        }

        static void RecursionMain(double indx) {

            int index = -1;
            bool good = false;

            string str = indx.ToString();

            //Find
            for (int i = 0; i < str.Length; i++) {
                good = false;
                for (int k = 0; k < 10; k++) {
                    string tempStr = k.ToString();
                    if (str[i] == tempStr[0]) {
                        good = true;
                        break;
                    }
                }
                if (!good) {
                    index = i;
                    break;
                }
            }
            //

            if (index == -1) {
                Recursion(str, 0);
            } else {
                string tempStr = str.Substring(index + 1,str.Length - (index+1));
                tempStr += str.Substring(index, 1);
                tempStr += str.Substring(0, index);
                Recursion(tempStr, 0);
            }

            Console.WriteLine();
        }

        static void RecursionMain(string indx, string magicSymbol) {
            string[] str = indx.Split(magicSymbol);

            string tempStr = "";
            for (int i = str.Length - 1; i >= 0; i--) {
                tempStr += str[i];

                if (i != 0 && str.Length !< 2) { 
                    tempStr += magicSymbol; 
                }
            }
            Recursion(tempStr, 0);
            Console.WriteLine();
        }

        static int Recursion(string str, int index) {
            if(index == str.Length - 1) {
                Console.Write(str[index]);
                return index - 1;
            } else {
                index++;
                index = Recursion(str, index);
                Console.Write(str[index]);
                return index - 1;
            }
        }


        //7

        static void OutMetod(out List<int> list) {
            list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++) {
                list.Add(rnd.Next(0, 31));
            }

            Console.Write("Масив: ");
            foreach (var i in list) {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            list.Reverse();
        }

        static void RefMetod(ref List<int> list) {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++) {
                list.Add(rnd.Next(0, 31));
            }

            Console.Write("Масив: ");
            foreach (var i in list) {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            list.Reverse();
        }
    }
}
