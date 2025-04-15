#!/bin/zsh

clear
echo "╔════════════════════════════════════════════════════╗"
echo "║ 🌈🦄   BIENVENUE DANS UNICORNLAND: LOGIC MODE   🦄🌈 ║"
echo "╚════════════════════════════════════════════════════╝"

read "NAME?Quel est ton prénom ?"
read "DAY?Jour ? (ex: day06) :"
read "EXO?Exo ? (ex: exo2) :"

echo ""
echo "🦄 Merci $NAME, lancement de $DAY / $EXO..."

# Make sure casing is correct
DAY_CAMEL="${DAY:l}"
EXO_CAMEL="${EXO:l}"
DAY_PASCAL="${DAY:u}"
EXO_PASCAL="$(echo "$EXO_CAMEL" | sed -E 's/(exo)([0-9]+)/\U\1\2/')"

# Construct path
EXO_PATH="UnicornLogic.${DAY_PASCAL}_UnicornChapter.${EXO_PASCAL}"

# Update Program.cs automatically
# Inject dispatcher call with variables
cat > ~/ProjectUnicornLogic/src/UnicornLogic/Program.cs <<EOF
namespace UnicornLogic;

class Program
{
    static void Main(string[] args)
    {
        UnicornDispatcher.Run("${DAY#day}", "${EXO#exo}");
    }
}
EOF

# Confirm update
echo "✅ Program.cs updated to run: $EXO_PATH"

# Attempt to run
dotnet run --project ~/ProjectUnicornLogic/src/UnicornLogic --configuration Release
