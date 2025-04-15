// namespace UnicornLogic.Day01_UnicornChapter;

// public static class Exo3
// {
//     public static void Run()
//     {
//         #region 🌈🦄 PROJECT UNICORN LOGIC – JOUR 01 EXO 3 ✨
//         Console.ForegroundColor = ConsoleColor.Magenta;
//         Console.WriteLine("╔══════════════════════════════════════════════╗");
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.WriteLine("║   🦄 PROJECT UNICORN LOGIC – INVERSION 🔁   ║");
//         Console.ForegroundColor = ConsoleColor.Magenta;
//         Console.WriteLine("╚══════════════════════════════════════════════╝");
//         Console.ResetColor();
//         Console.WriteLine();
//         #endregion

//         Console.Write("Combien de nombres souhaitez-vous entrer ? ");
//         int taille = int.Parse(Console.ReadLine());

//         int[] tableau = new int[taille];

//         for (int i = 0; i < taille; i++)
//         {
//             Console.Write($"Entrez la valeur #{i + 1} : ");
//             tableau[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("\nTableau original :");
//         foreach (int val in tableau)
//         {
//             Console.Write(val + " ");
//         }

//         for (int i = 0; i < tableau.Length / 2; i++)
//         {
//             int temp = tableau[i];
//             tableau[i] = tableau[taille - 1 - i];
//             tableau[taille - 1 - i] = temp;
//         }

//         Console.WriteLine("\n\nTableau inversé :");
//         foreach (int val in tableau)
//         {
//             Console.Write(val + " ");
//         }

//         // ALTERNATIVE : Utilisation de Array.Reverse
//         /*
//         Array.Reverse(tableau);
//         Console.WriteLine("\n\n[Alternative] Tableau inversé :");
//         foreach (int val in tableau)
//         {
//             Console.Write(val + " ");
//         }
//         */
//     }
// }