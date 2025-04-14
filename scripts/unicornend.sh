#!/bin/zsh

echo "🦄 Saving your magical progress..."
cd ~/ProjectUnicornLogic || exit 1

git add .
echo "✨ What’s your commit message?"
read COMMIT_MSG

git commit -m "$COMMIT_MSG"
git push origin main

echo "✅ All changes have been pushed to GitHub!"
