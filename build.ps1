Write-Host "Restaurando dependências..."
dotnet restore src/Application/Application.fsproj
dotnet restore src/CrossCutting/CrossCutting.fsproj
dotnet restore tests/Application.Tests/Application.Tests.fsproj

Write-Host "Compilando projetos..."
dotnet build src/Application/Application.fsproj
dotnet build src/CrossCutting/CrossCutting.fsproj
dotnet build tests/Application.Tests/Application.Tests.fsproj

Write-Host "Executando testes..."
dotnet test tests/Application.Tests/Application.Tests.fsproj