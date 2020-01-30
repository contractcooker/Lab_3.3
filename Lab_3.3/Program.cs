using System;
using System.Collections.Generic;

namespace Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            

            Console.Write("Please enter a word you would like to reverse: ");

            input = Console.ReadLine();

            Console.WriteLine("Your word reversed is: {0}",ReverseString(input)); 
            
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
