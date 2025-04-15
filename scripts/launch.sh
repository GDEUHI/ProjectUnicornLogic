#!/bin/zsh

clear
echo "╔════════════════════════════════════════════════════╗"
echo "║ 🌈🦄   BIENVENUE DANS UNICORNLAND: LOGIC MODE   🦄🌈 ║"
echo "╚════════════════════════════════════════════════════╝"

read "NAME?Quel est ton prénom ? "
read "DAY?Jour ? (ex: day06) : "
read "EXO?Exo ? (ex: exo2) : "

DAY_PASCAL="Day${DAY#day}"
EXO_PASCAL="Exo${EXO#exo}"

EXO_PATH="UnicornLogic.${DAY_PASCAL}_UnicornChapter.${EXO_PASCAL}"

echo "✅ Updating Program.cs to run: ${EXO_PATH}"

cat <<EOF > ~/ProjectUnicornLogic/src/UnicornLogic/Program.cs
namespace UnicornLogic;

public class Program
{
    public static void Main(string[] args)
    {
        ${EXO_PATH}.Run();
    }
}
EOF
