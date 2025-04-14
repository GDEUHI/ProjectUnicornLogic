#!/bin/bash

# 🦄 launch.sh – Magical unicorn day/exo runner
DAY=$1
EXO=$2

if [ -z "$DAY" ] || [ -z "$EXO" ]; then
  echo "❌ Usage: ./launch.sh dayXX exoX"
  echo "✅ Example: ./launch.sh day07 exo3"
  exit 1
fi

EXO_UPPER=$(echo "$EXO" | tr '[:lower:]' '[:upper:]')
DAY_CLASS="UnicornLogic.${DAY^}_UnicornChapter.${EXO_UPPER}"

echo "✨ Switching Program.cs to → $DAY_CLASS.Run();"

cat > src/UnicornLogic/Program.cs <<EOF
﻿namespace UnicornLogic;

class Program
{
    static void Main(string[] args)
    {
        $DAY_CLASS.Run();
    }
}
EOF

# OPTIONAL: open the exercise in code
echo "🦄 Opening file: src/UnicornLogic/${DAY^}_UnicornChapter/${EXO_UPPER}.cs"
code "src/UnicornLogic/${DAY^}_UnicornChapter/${EXO_UPPER}.cs"

# Run the project
echo "🚀 Running Unicorn Logic!"
dotnet run --project src/UnicornLogic

