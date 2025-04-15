#!/bin/zsh

echo "🧽 Cleaning & formatting your Unicorn code..."

cd ~/ProjectUnicornLogic/src/UnicornLogic || exit

# Format C# code
dotnet format UnicornLogic.csproj --verbosity minimal

# Check for duplicate namespace declarations
echo "🔍 Checking for duplicate namespaces in EXO files..."
grep -rl "namespace UnicornLogic" . | grep Exo | while read file; do
    count=$(grep -c "namespace UnicornLogic" "$file")
    if [ $count -gt 1 ]; then
        echo "⚠️  Double namespace found in $file"
    fi
done

echo "✅ All done!"
