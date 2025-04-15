namespace UnicornLogic.Day06_UnicornChapter;

public static class Exo4
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – Exo4 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR 06 EXO 4  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🎯 EXO LABEL BANNER
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║   🦄 JOUR 06 – EXO 4 : RECHERCHER UNE VALEUR DANS TABLEAU ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🚀 LOGIC
        int[] tableau = new int[6];

        for (int i = 0; i < tableau.Length; i++)
        {
            Console.Write($"Entrez le nombre #{i + 1} : ");
            tableau[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\n🔍 Entrez la valeur à rechercher : ");
        int recherche = int.Parse(Console.ReadLine());

        int position = -1;

        for (int i = 0; i < tableau.Length; i++)
        {
            if (tableau[i] == recherche)
            {
                position = i;
                break;
            }
        }

        Console.WriteLine(position != -1
            ? $"✅ Valeur trouvée à la position {position}"
            : "❌ Valeur non trouvée (résultat : -1)");

        // 🔄 ALTERNATE (plus avancé)
        /*
        int posAlt = Array.IndexOf(tableau, recherche);
        Console.WriteLine(posAlt != -1
            ? $"[Alternative] ✅ Trouvée à l'index : {posAlt}"
            : "[Alternative] ❌ Pas trouvée.");
        */
        #endregion
    }
}