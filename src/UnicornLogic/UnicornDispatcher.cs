using System;

namespace UnicornLogic;

public static class UnicornDispatcher
{
    public static void Run(string day, string exo)
    {
        string dayNamespace = $"UnicornLogic.Day{day}_UnicornChapter";
        string className = $"Exo{exo}";

        Type? type = Type.GetType($"{dayNamespace}.{className}");

        if (type == null)
        {
            Console.WriteLine($"❌ Impossible de trouver : {dayNamespace}.{className}");
            return;
        }

        var runMethod = type.GetMethod("Run");
        if (runMethod == null)
        {
            Console.WriteLine($"❌ La méthode 'Run' est absente dans {className}");
            return;
        }

        runMethod.Invoke(null, null);
    }
}
