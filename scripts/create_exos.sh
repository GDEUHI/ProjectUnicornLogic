#!/bin/bash

echo "🛠️ Creating EXO files for 20 Unicorn Days..."

for day in {1..20}; do
    daydir=$(printf "Day%02d_UnicornChapter" "$day")
    basedir="src/UnicornLogic/$daydir"
    mkdir -p "$basedir"

    for exo in {1..4}; do
        exo_file="$basedir/Exo${exo}.cs"
        if [[ -f "$exo_file" ]]; then
            echo "⚠️  Skipping existing $exo_file"
            continue
        fi

        cat <<EOF > "$exo_file"
namespace UnicornLogic.${daydir};

public static class Exo${exo}
{
    public static void Run()
    {
        #region 🌈🦄 PROJECT UNICORN LOGIC – JOUR $(printf "%02d" $day) EXO ${exo} ✨
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  🦄 PROJECT UNICORN LOGIC – JOUR $(printf "%02d" $day) EXO ${exo}  ║");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        #endregion

        // 🧠 Ton code ici...

        // 🌟 ALTERNATIVE :
        /*
        // Code plus avancé (niveau supérieur)
        */
    }
}
EOF

        echo "✅ Created $exo_file"
    done
done

echo "🎉 All EXO files created!"
