using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter a term to search for: ");
            string answer = Console.ReadLine();
            sentence = sentence.ToUpper();
            answer = answer.ToUpper();
            int tester = sentence.IndexOf(answer);
            if(tester != -1)
            {
                result = true;
            }

            Console.WriteLine(result);
            Console.WriteLine(answer.Length);
            Console.WriteLine(tester);

            string[] sentenceArr = sentence.Split(answer);

            string newSentence = sentenceArr[0] + sentenceArr[1];

            Console.WriteLine(newSentence);

        }
    }
}
