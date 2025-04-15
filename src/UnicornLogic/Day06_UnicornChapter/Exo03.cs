namespace UnicornLogic.Day06_UnicornChapter;

public static class Exo3
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – Exo3 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR 06 EXO 3  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🎯 EXO LABEL BANNER
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║   🦄 JOUR 06 – EXO 3 : INVERSION DE TABLEAU     ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🚀 LOGIC
        int[] tableauOriginal = new int[6];
        int[] tableauInverse = new int[6];

        for (int i = 0; i < tableauOriginal.Length; i++)
        {
            Console.Write($"Entrez le nombre #{i + 1} : ");
            tableauOriginal[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < tableauOriginal.Length; i++)
        {
            tableauInverse[i] = tableauOriginal[tableauOriginal.Length - 1 - i];
        }

        Console.WriteLine("\n🔁 Tableau inversé :");
        foreach (int n in tableauInverse)
        {
            Console.WriteLine($"🌟 {n}");
        }

        // ALTERNATE : Inversion sans second tableau
        /*
        Array.Reverse(tableauOriginal);
        Console.WriteLine("\n🧪 [Alternative] Inversion avec Array.Reverse :");
        foreach (int n in tableauOriginal)
        {
            Console.WriteLine($"✨ {n}");
        }
        */
        #endregion
    }
}