# projetoAutomacaoCSharp

Passo a Passo:

Baixar VS code

Instalar Extenções:
- .NET core test explorer
- C#
- C# extensions
- C# fix format
- Darcula theme (opcional)

Instalar NET Core SDK 
Executar o comando < dotnet --version > para verificar

Criar projeto atraves do terminal usando o comando: dotnet new xunit --name "nomeDoProjeto"

Criar Solution com o comando: dotnet new solution

Abrir pasta no VS code: code .

Arquivo .csproj (Serve para mostrar as extencoes do projeto)

Adicionar extencoes:
< src/nomeProjeto > 
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Selenium.Webdriver

Navegar ate a pasta inicial "cd.. cd.."
Adicionar projeto ao Solution: dotnet sln add .\src\pasta\seuarquivo.csproj

Adicionar ChromeDriver na pasta do projeto

< src/nomeProjeto > Criar arquivo appsettings.json  
