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

- adicionar class library a solution: dotnet sln add CloudStorageSolution.Application/CloudStorageSolution.Application.csproj

- adicionar reference: dotnet add CloudStorageSolution.Api/CloudStorageSolution.Api.csproj reference CloudStorageSolution.Application/CloudStorageSolution.Application.csproj

- adicionar nuget package: dotnet add CloudStorageSolution.Application package File.TypeChecker --version 4.0.0

- criar class library: dotnet new classlib --output CloudStorageSolution.Infrastructure

- adicionar class library a solution: dotnet sln add CloudStorageSolution.Infrastructure/CloudStorageSolution.Infrastructure.csproj

- criar class library: dotnet new classlib --output CloudStorageSolution.Domain

- adicionar class library a solution: dotnet sln add CloudStorageSolution.Domain/CloudStorageSolution.Domain.csproj

- adicionar reference: dotnet add CloudStorageSolution.Application/CloudStorageSolution.Application.csproj reference CloudStorageSolution.Domain/CloudStorageSolution.Domain.csproj

- adicionar reference: dotnet add CloudStorageSolution.Infrastructure/CloudStorageSolution.Infrastructure.csproj reference CloudStorageSolution.Domain/CloudStorageSolution.Domain.csproj

#### 1:15:55
