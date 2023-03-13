using System;

namespace CalculateSameLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter phrase");
            string phrase = Console.ReadLine();

            char[] characters = new char[phrase.Length];

            for (int i = 0; i < phrase.Length; i++)
            {
                int counter = 0;
                if (phrase[i] != ' ')
                {
                    if (!CheckIfExistValue(characters, phrase[i]))
                    {
                        characters[i] = phrase[i];
                        for (int j = 0; j < phrase.Length; j++)
                        {
                            if (phrase[i] == phrase[j])
                            {
                                counter++;
                            }
                        }
                    }
                }
                if (counter != 0)
                {
                    Console.WriteLine(phrase[i] + " - " + counter);
                }
            }
        }
        public static bool CheckIfExistValue(char[] cc, char c)
        {
            for (int i = 0; i < cc.Length; i++)
            {
                if (cc[i] == c) return true;
            }
            return false;
        }
    }
}
