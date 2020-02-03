using System;
using System.Collections.Generic;

namespace Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string input;
                string[] myArr;
                bool valid = true;


                Console.Write("Please enter a sentence (no punctuation) you would like to reverse: ");

                input = Console.ReadLine();

                do
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!"qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ".Contains(input[i]))
                        {
                            Console.Write("Invalid input! Please enter a sentence (no punctuation) you would like to reverse: ");

                            input = Console.ReadLine();
                            valid = false;
                            break;
                        }
                        else
                        {
                            valid = true;
                        }
                    }

                } while (!valid);

                myArr = input.Split(" ");

                Console.Write("Your sentence reversed is: ");
                for (int i = 0; i < myArr.Length; i++)
                {
                    Console.Write($"{ReverseString(myArr[i])} ");
                }
                Console.WriteLine();
            } while (true);
            //Console.WriteLine("Your word reversed is: {0}",ReverseString(input)); 
            
        }

        private static string ReverseString(string input)
        {
            Stack<char> myStack = new Stack<char>();

            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                myStack.Push(charArray[i]);
            }
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = myStack.Pop();
            }
            string reversedInput = new string(charArray);

            return reversedInput;
        }
    }
}
