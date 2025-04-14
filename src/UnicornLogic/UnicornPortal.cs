using System.Diagnostics;

namespace UnicornLogic;

public static class UnicornPortal
{
    public static void Run()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔════════════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║ 🌈🦄   BIENVENUE DANS UNICORNLAND: LOGIC MODE   🦄🌈 ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚════════════════════════════════════════════════════╝");
        Console.ResetColor();

        Console.Write("Quel est ton prénom ? ");
        var name = Console.ReadLine();

        Console.Write("Jour ? (ex: day06) : ");
        var day = Console.ReadLine();

        Console.Write("Exo ? (ex: exo2) : ");
        var exo = Console.ReadLine();

        Console.WriteLine($"\n🦄 Merci {name}, lancement de {day} / {exo}...");

        try
        {
            Process.Start("bash", $"-c \"./scripts/launch.sh {day} {exo}\"");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erreur : " + e.Message);
        }
    }
}
