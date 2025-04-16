using System;
using System.Threading.Tasks;


namespace Utils;

public static class ConsoleUtils
{
    public static void AnimeText(string text, int delay = 10)
    {

        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
}