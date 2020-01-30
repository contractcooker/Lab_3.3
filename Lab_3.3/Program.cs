using System;
using System.Collections.Generic;

namespace Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, reverseInput="";
            char[] charArray;
            Stack<char> myStack = new Stack<char>();

            Console.Write("Please enter a word you would like to reverse: ");

            input = Console.ReadLine();
            charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                myStack.Push(charArray[i]);
            }
            for (int i = myStack.Count; i > 0; i--)
            {
               reverseInput += myStack.Pop;
            }
        }
    }
}
