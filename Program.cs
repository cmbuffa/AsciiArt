using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = 4;//int.Parse(Console.ReadLine());
            int H = 5;//int.Parse(Console.ReadLine());
            Console.Write("Insert word to print: ");
            string text = Console.ReadLine();
            string[] row = new string[H];

            System.IO.StreamReader file = new System.IO.StreamReader("Ascii.txt");

            for (int i = 0; i < H; i++)
            {
                row[i] = file.ReadLine();
            }

            Solution.PrintAsciiArt(H, L, text, row);

            Console.ReadLine();
        }
    }
}
