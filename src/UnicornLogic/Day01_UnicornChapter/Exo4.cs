namespace UnicornLogic.Day01_UnicornChapter;

public static class Exo4
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – JOUR 01 EXO 4 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║   🦄 PROJECT UNICORN LOGIC – RECHERCHE 🔎   ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        int[] tableau = new int[] { 3, 5, 8, 13, 21, 34 };

        Console.Write("Quelle valeur voulez-vous rechercher ? ");
        int valeur = int.Parse(Console.ReadLine());

        int position = -1;
        for (int i = 0; i < tableau.Length; i++)
        {
            if (tableau[i] == valeur)
            {
                position = i;
                break;
            }
        }

        if (position != -1)
        {
            Console.WriteLine($"✅ Valeur trouvée à la position {position} !");
        }
        else
        {
            Console.WriteLine("❌ Valeur non trouvée.");
        }

        // ALTERNATIVE : Avec Array.IndexOf
        /*
        int pos = Array.IndexOf(tableau, valeur);
        Console.WriteLine(pos != -1 ? $"[Alternative] Trouvée à {pos}" : "[Alternative] Pas trouvée");
        */
    }
}