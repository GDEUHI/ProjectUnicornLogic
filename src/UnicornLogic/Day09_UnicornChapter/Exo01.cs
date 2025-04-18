namespace UnicornLogic.Day09_UnicornChapter;

public static class Exo1
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – Exo1 ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR 09 EXO 1  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        // Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AfficherBannière();

            int scoreJoueur = 0;
            int scoreMachine = 0;
            string[] options = { "pierre", "feuille", "ciseau" };
            Random random = new Random();

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("👉 Entrez votre choix (pierre, feuille, ciseau) : ");
                string? choixJoueur = Console.ReadLine()?.Trim().ToLower();
                Console.ResetColor();

                if (!Array.Exists(options, o => o == choixJoueur))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⛔ Choix invalide. Réessayez.\n");
                    Console.ResetColor();
                    continue;
                }

                string choixMachine = options[random.Next(0, 3)];
                Console.WriteLine($"🤖 La machine a choisi : {choixMachine}\n");

                string resultat = ComparerChoix(choixJoueur, choixMachine);

                if (resultat == "joueur")
                {
                    scoreJoueur++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("✅ Vous gagnez ce tour !");
                }
                else if (resultat == "machine")
                {
                    scoreMachine++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ La machine gagne ce tour !");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("🔄 Égalité !");
                }

                Console.ResetColor();
                Console.WriteLine($"\n🔢 Score actuel — Vous: {scoreJoueur} | Machine: {scoreMachine}\n");

            } while (scoreJoueur < 2 && scoreMachine < 2);

            Console.ForegroundColor = ConsoleColor.Magenta;
            if (scoreJoueur == 2)
                Console.WriteLine("🎉 Vous avez gagné la partie ! 🦄");
            else
                Console.WriteLine("💀 La machine a gagné... une autre fois peut-être !");
            Console.ResetColor();
        }

        static void AfficherBannière()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║   🎮 Pierre - Feuille - Ciseau | Jour 9   ║");
            Console.WriteLine("╚══════════════════════════════════════════╝\n");
            Console.ResetColor();
        }

        static string ComparerChoix(string joueur, string machine)
        {
            if (joueur == machine) return "egal";

            if ((joueur == "pierre" && machine == "ciseau") ||
                (joueur == "feuille" && machine == "pierre") ||
                (joueur == "ciseau" && machine == "feuille"))
            {
                return "joueur";
            }
            else
            {
                return "machine";
            }
    }
}
