using System;
using System.Collections.Generic;

namespace morzeCode
{
    class Program
    {
        public static string[] tableMorze = new string[] {".-", "-...", "-.-.", "-..",
                                                        ".", "..-.", "--.", "....",
                                                        "..", ".---", "-.-", ".-..",
                                                        "--", "-.", "---", ".--.",
                                                        "--.-", ".-.", "...", "-",
                                                        "..-", "...-", ".--",
                                                        "-..-", "-.--", "--.."
        };

        public static string[] abc = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I",
                                                        "J", "K", "L", "M", "N", "O", "P", "Q", "R",
                                                        "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        public static string endMessage = "Your message: ";

        static string morzeDecoder(string morzeMessage)
        {
            string[] message = morzeMessage.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j <= 25; j++)
                {
                    if (message[i] == tableMorze[j])
                    {
                        endMessage += abc[j];
                    }
                }
            }
            return endMessage;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Good afternoon! Let's decode your message");
                Console.WriteLine("Enter the morse code\n");
                string morzeMessage = Console.ReadLine();
                Console.WriteLine(morzeDecoder(morzeMessage));
                endMessage = "Message: ";
                Console.WriteLine("  ");
            }
        }
    }
}
