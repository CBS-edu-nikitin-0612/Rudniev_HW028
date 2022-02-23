using System;
using System.Text;
using System.Collections.Generic;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;

            var dictionary = new List<dynamic>
            {
                new
                {
                    ang = "apple",
                    rus = "яблоко"
                },
                new
                {
                    ang = "phone",
                    rus = "телефон"
                },
                new
                {
                    ang = "house",
                    rus = "дом"
                },
                new
                {
                    ang = "lable",
                    rus = "метка"
                },
                new
                {
                    ang = "book",
                    rus = "книга"
                },
                new
                {
                    ang = "sun",
                    rus = "сонце"
                },
                new
                {
                    ang = "featherlight",
                    rus = "как пёрышко"
                },
                new
                {
                    ang = "car",
                    rus = "машина"
                },
                new
                {
                    ang = "neigbor",
                    rus = "сосед"
                },
                new
                {
                    ang = "boll",
                    rus = "мяч"
                },
            };

            foreach (var word in dictionary)
                Console.WriteLine($"{word.ang} - {word.rus}");
        }
    }
}
