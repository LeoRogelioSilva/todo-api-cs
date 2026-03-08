#!/bin/bash

set -e  # Interrompe o script se algum comando falhar

echo "🧹 Limpando pastas bin e obj..."
find . -type d \( -name bin -o -name obj \) -exec rm -rf {} + 2>/dev/null || true

echo "🔨 Buildando projeto..."
dotnet build TodoApi.slnx

echo "🚀 Rodando aplicação..."
dotnet run --project src/TodoApi.Api
