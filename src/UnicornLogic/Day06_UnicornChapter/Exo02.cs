namespace UnicornLogic.Day06_UnicornChapter;

public static class Exo2
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – Exo2 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR 06 EXO 2  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 JOUR 06 – EXO 2 : MOYENNE DES SCORES     ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();

        #region 🚀 LOGIC

        Console.Write("Combien de joueurs ? (max 10) : ");
        int nbJoueurs = int.Parse(Console.ReadLine());

        if (nbJoueurs > 10)
        {
            Console.WriteLine("❌ Trop de joueurs !");
            return;
        }

        int[] scores = new int[nbJoueurs];
        int somme = 0;

        for (int i = 0; i < nbJoueurs; i++)
        {
            Console.Write($"Score du joueur {i + 1} : ");
            scores[i] = int.Parse(Console.ReadLine());
            somme += scores[i];
        }

        double moyenne = (double)somme / nbJoueurs;
        Console.WriteLine($"\n🎯 Moyenne des scores : {moyenne}");

        // 🧪 ALTERNATE: Avec LINQ
        // double moyenneAlt = scores.Average();
        // Console.WriteLine($"[Alternative] Moyenne avec LINQ : {moyenneAlt}");

        #endregion
    }
}
