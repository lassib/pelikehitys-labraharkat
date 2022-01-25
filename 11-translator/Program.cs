using System;

namespace _11_translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is translator");
            Translator theTranslator = new Translator();
            theTranslator.translate();
        }
    }
}