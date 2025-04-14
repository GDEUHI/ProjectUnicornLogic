// namespace UnicornLogic.Day01_UnicornChapter;

// // public static class Exo2
// {
//     public static void Run()
//     {
//         #region 🌈🦄 PROJECT UNICORN LOGIC – JOUR 01 EXO 2 ✨
//         Console.ForegroundColor = ConsoleColor.Magenta;
//         Console.WriteLine("╔══════════════════════════════════════════════╗");
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – MOYENNE SCORES   ║");
//         Console.ForegroundColor = ConsoleColor.Magenta;
//         Console.WriteLine("╚══════════════════════════════════════════════╝");
//         Console.ResetColor();
//         Console.WriteLine();
//         #endregion

//         Console.Write("Combien de joueurs ? (max 10) : ");
//         int nbJoueurs = int.Parse(Console.ReadLine());

//         if (nbJoueurs > 10)
//         {
//             Console.WriteLine("❌ Trop de joueurs !");
//             return;
//         }

//         int[] scores = new int[nbJoueurs];
//         int somme = 0;

//         for (int i = 0; i < nbJoueurs; i++)
//         {
//             Console.Write($"Score du joueur {i + 1} : ");
//             scores[i] = int.Parse(Console.ReadLine());
//             somme += scores[i];
//         }

//         double moyenne = (double)somme / nbJoueurs;
//         Console.WriteLine($"\n🎯 Moyenne des scores : {moyenne}");

//         // ALTERNATIVE : Moyenne calculée avec LINQ (plus avancé)
//         /*
//         double moyenneAlt = scores.Average();
//         Console.WriteLine($"[Alternative] Moyenne avec LINQ : {moyenneAlt}");
//         */
//     }
// }