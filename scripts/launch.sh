#!/bin/bash

DAY=$1
EXO=$2

FILE="src/UnicornLogic/${DAY}_UnicornChapter/${EXO^}.cs"

if [[ -f "$FILE" ]]; then
    echo "🦄✨ Exécution de ${FILE}..."
    dotnet run --project src/UnicornLogic --configuration Release
else
    echo "❌ Fichier ${FILE} introuvable."
fi
