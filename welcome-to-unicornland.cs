using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.UTF8;

#region 🦄 WELCOME TO UNICORNLAND

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("╔════════════════════════════════════════════════════╗");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("║ 🌈🦄   BIENVENUE DANS UNICORNLAND: LOGIC MODE   🦄🌈 ║");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("╚════════════════════════════════════════════════════╝");
Console.ResetColor();

#endregion

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Quel est ton prénom, aventurier du code ? 🧙‍♀️🧑‍🚀🧝‍♂️ : ");
string? name = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("\n🗓 Quel jour veux-tu explorer ? (ex: day06) : ");
string? day = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("🎯 Quelle Exo veux-tu lancer ? (ex: exo2) : ");
string? exo = Console.ReadLine();

Console.ResetColor();
Console.WriteLine("\n🔧 Initialisation du lancement magique…");

string command = $"./launch.sh {day} {exo}";
Console.WriteLine($"🚀 Commande terminal : {command}");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"\nMerci {name}, que la logique soit avec toi 🧠🌌 !");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n🦄✨ UNICORNLAND INITIATING ✨🦄\n");
Console.ResetColor();

#region 🛸 LAUNCH
try
{
    Process.Start("bash", $"-c \"{command}\"");
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("💥 Erreur : " + ex.Message);
    Console.ResetColor();
}
#endregion
