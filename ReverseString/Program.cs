using System;
using System.Linq;

namespace ReverseStringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your word/sentence you want to reverse: ");
            var word = Console.ReadLine();
			var result = ReverseString.Reverse(word);
			Console.WriteLine(string.Format("You write: {0} and the reverse is: {1}", word, result));
			Console.ReadKey();
        }
    }

 public static class ReverseString
 {
     public static string Reverse(string input) => string.Join(string.Empty, input.Reverse());
 }
}


