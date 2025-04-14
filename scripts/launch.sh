#!/bin/bash

echo
echo "🦄 Merci $NAME, lancement de $DAY / $EXO..."

# 🧠 Normalize and find the right file, ignoring case
EXO_UPPER="$(echo "$EXO" | sed -E 's/^([a-z])/\U\1/')"
FILE="src/UnicornLogic/${DAY}_UnicornChapter/${EXO_UPPER}.cs"

if [[ -f "$FILE" ]]; then
  echo "✅ Fichier trouvé : $FILE"
  echo "🚀 Exécution en cours..."
  dotnet run --project src/UnicornLogic --configuration Release
else
  echo "❌ Fichier $FILE introuvable."
fi
