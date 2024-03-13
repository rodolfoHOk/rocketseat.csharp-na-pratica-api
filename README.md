# C# na prática

> RocketSeat

## Tecnologias

- C#
- .NET

## DotNet Commands

- criar e entrar na pasta CloudStorage

- criar nova solution: dotnet new sln --name CloudStorageSolution

- criar gitignore: dotnet new gitignore

- criar projeto web api: dotnet new webapi --use-controllers --output CloudStorageSolution.Api

- adicionar projeto web api a solution: dotnet sln add CloudStorageSolution.Api

- rodar projeto web api: dotnet run --project CloudStorageSolution.Api/CloudStorageSolution.Api.csproj

- criar class library: dotnet new classlib --output CloudStorageSolution.Application

- adicionar projeto class library a solution: dotnet sln add CloudStorageSolution.Application/CloudStorageSolution.Application.csproj
