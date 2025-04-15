namespace UnicornLogic.Day06_UnicornChapter;

public static class Exo5
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – Exo5 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR 06 EXO 5  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🎯 EXO LABEL BANNER
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔═════════════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║     🦄 JOUR 06 – EXO 5 : LE PION QUI BOUGE          ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚═════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        #region 🚀 LOGIC
        const int taille = 10;
        char[] plateau = new char[taille];

        for (int i = 0; i < taille; i++)
            plateau[i] = '.';

        int position = 0;
        plateau[position] = 'P';

        string commande = "";

        while (commande != "q")
        {
            Console.Clear();

            Console.WriteLine("🎮 Plateau : " + new string(plateau));
            Console.Write("➡️ Commande (g = gauche, d = droite, q = quitter) : ");
            commande = Console.ReadLine();

            plateau[position] = '.';

            if (commande == "g" && position > 0)
                position--;
            else if (commande == "d" && position < taille - 1)
                position++;

            plateau[position] = 'P';
        }
        #endregion
    }
}