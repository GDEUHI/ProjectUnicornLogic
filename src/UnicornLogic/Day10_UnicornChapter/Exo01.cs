namespace UnicornLogic.Day10_UnicornChapter;

public static class Exo1
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – Exo1 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR 10 EXO 1  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

     using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // STEP 1: ARRAY
        string[] languages = { "EN", "FR", "ES", "IT", "DE" };

        // STEP 2: 2D ARRAY
        string[,] langGreetings = {
            {"EN", "Hello"},
            {"FR", "Bonjour"},
            {"ES", "Hola"},
            {"IT", "Ciao"},
            {"DE", "Hallo"}
        };

        // STEP 3: LIST
        List<string> greetingsList = new List<string>();
        for (int i = 0; i < languages.Length; i++)
        {
            greetingsList.Add(langGreetings[i, 1]);
        }

        // STEP 4: DICTIONARY
        Dictionary<string, string> helloDict = new Dictionary<string, string>();
        for (int i = 0; i < languages.Length; i++)
        {
            helloDict[languages[i]] = langGreetings[i, 1];
        }

        // STEP 5: DISPLAY RESULTS
        Console.WriteLine("Greetings using array:");
        foreach (var lang in languages)
        {
            Console.WriteLine(lang);
        }

        Console.WriteLine("\nGreetings using 2D array:");
        for (int i = 0; i < langGreetings.GetLength(0); i++)
        {
            Console.WriteLine($"{langGreetings[i, 0]}: {langGreetings[i, 1]}");
        }

        Console.WriteLine("\nGreetings using List:");
        foreach (var greeting in greetingsList)
        {
            Console.WriteLine(greeting);
        }

        Console.WriteLine("\nGreetings using Dictionary:");
        foreach (var pair in helloDict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}   // 👉 Code à écrire ici
    }
}
