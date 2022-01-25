using System;
using System.Collections.Generic;
using System.Text;

namespace _11_translator
{
    class Translator
    {
        public void translate()
        {
            bool state = true;
            var words = new Dictionary<string, string>()
            {
                {"kello", "clock"},
                {"kana", "chicken"},
                {"pöytä", "table" }
            };

            while(state == true)
            {
                Console.WriteLine("Give a word in finnish: ");
                string word = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    state = false;
                    Console.WriteLine("Your word in english: " + words[word]);
                }
                else
                {
                    Console.WriteLine("Your word was not in the dictionary");
                }
            }
        }
    }
}