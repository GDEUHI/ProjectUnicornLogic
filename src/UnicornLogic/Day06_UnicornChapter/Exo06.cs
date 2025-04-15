namespace UnicornLogic.Day06_UnicornChapter;

public static class Exo06
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – Exo6 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR 06 EXO 6  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🎯 EXO LABEL BANNER
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║   🦄 JOUR 06 – EXO 6 : TRIER UN TABLEAU          ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        int[] tableau = new int[6];

        for (int i = 0; i < tableau.Length; i++)
        {
            Console.Write($"Entrez le nombre #{i + 1} : ");
            tableau[i] = int.Parse(Console.ReadLine());
        }

        // Tri à bulles (bubble sort)
        for (int i = 0; i < tableau.Length - 1; i++)
        {
            for (int j = 0; j < tableau.Length - i - 1; j++)
            {
                if (tableau[j] > tableau[j + 1])
                {
                    int temp = tableau[j];
                    tableau[j] = tableau[j + 1];
                    tableau[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\n✅ Tableau trié en ordre croissant :");
        foreach (int n in tableau)
        {
            Console.WriteLine($"🌟 {n}");
        }

        // ALTERNATE : Utiliser Array.Sort (simple mais sans boucle manuelle)
        /*
        Array.Sort(tableau);
        Console.WriteLine("🌈 [Alternative] Tri avec Array.Sort : " + string.Join(", ", tableau));
        */
    }
}