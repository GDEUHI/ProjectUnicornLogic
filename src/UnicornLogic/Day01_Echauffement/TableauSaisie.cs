namespace UnicornLogic.Day01_Echauffement;

public static class TableauSaisie
{
    public static void Run()
    {
        // 🦄 Your cosmic code starts here...
        #region 🌈🦄 PROJECT UNICORN LOGIC – TableauSaisie ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – TABLEAU ✨ ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        int[] nombres = new int[6];

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Entrez le nombre #{i + 1} : ");
            nombres[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVous avez saisi les nombres suivants :");
        foreach (int nombre in nombres)
        {
            Console.WriteLine($"🌟 {nombre}");
        }

        // ALTERNATIVE : Affichage avec une boucle for
        /*
        Console.WriteLine("\nAffichage alternatif :");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"📦 Index {i} : {nombres[i]}");
        }
        */
    }
}