using System.Globalization;

namespace UnicornLogic.Day06_UnicornChapter;

public static class Exo1
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – Exo1 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR 06 EXO 1  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🌈🦄 PROJECT UNICORN LOGIC – JOUR 06 EXO 1 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔════════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║     🦄 JOUR 06 – EXO 1 : TABLEAU 6 ENTIERS     ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🚀 LOGIC
        int[] nombres = new int[6];

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Entrez le nombre #{i + 1} : ");
            nombres[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n📦 Vous avez saisi les nombres suivants :");
        foreach (int n in nombres)
        {
            Console.WriteLine($"🌟 {n}");
        }

        // ALTERNATE : Impression rapide avec Join()
        // Console.WriteLine("🌈 [Alternative] " + string.Join(", ", nombres));
        #endregion
    }
}