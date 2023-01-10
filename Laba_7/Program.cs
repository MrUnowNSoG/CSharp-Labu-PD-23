using System;
using System.Collections.Generic;

namespace Laba_7 {
    class Program {
        static void Main(string[] args) {

            List<char> str = new List<char>();
            string text = "";

            Console.WriteLine("Please write text:");

            //
            text = Console.ReadLine();
            foreach(char i in text) {
                str.Add(i);
            }

            Console.WriteLine("Please write special symbol:");
            text = Console.ReadLine();
            char ch = text[0];

            Console.WriteLine("Index replace:");
            for(int i = 0; i < str.Count; i++) {
                if(ch == str[i]) {
                    Console.Write(i + ", ");
                }
            }

        }
    }
}
