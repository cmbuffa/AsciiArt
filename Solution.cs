using System;
using System.IO;
using System.Linq;


public class Solution
{
    //static void Main(string[] args)
    //{
    //    int L = int.Parse(Console.ReadLine());
    //    int H = int.Parse(Console.ReadLine());
    //    string text = Console.ReadLine();
    //    string[] row = new string[H];

    //    for (int i = 0; i < H; i++)
    //    {
    //        row[i] = Console.ReadLine();            
    //    }
        
    //    PrintAsciiArt(H, L, text, row);
    //}

    public static void PrintAsciiArt(int h, int l, string text, string[] row)
    {
        string line = "";
        
        for(int i = 0; i < h; i++)
        {
            for(int j = 0; j < text.Length; j++)
            {
                line = GetLine(i, h, l, text[j], row, line);
            }
            Console.WriteLine(line);
            line = "";
        }
    }

    public static string GetLine(int i,int h, int l, char letter, string[] row, string line)
    {
        int index ="ABCDEFGHIJKLMNOPQRSTUVWXYZ?".IndexOf(char.ToUpper(letter));
        index = index < 0 ? 26: index;
        for(int j = index * l; j < (index * l) + l ; j++ )
        {
            line += row[i].ToArray()[j];
        }
        return line;
    }
}