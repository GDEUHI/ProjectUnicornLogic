#!/bin/zsh

echo "🧞‍♂️ Summoning the Unicorn Genie..."

cd ~/ProjectUnicornLogic/src/UnicornLogic || exit

# Step 1: Format code
echo "🛠️ Formatting all .cs files..."
dotnet format UnicornLogic.csproj --verbosity minimal

# Step 2: Check for double namespaces
echo "🔍 Scanning for duplicate namespaces in EXO files..."
grep -rl "namespace UnicornLogic" . | grep Exo | while read file; do
    count=$(grep -c "namespace UnicornLogic" "$file")
    if [ $count -gt 1 ]; then
        echo "⚠️  Double namespace in: $file"
    fi
done

echo "✅ All done. Genie has cleaned your unicorn cave!"
