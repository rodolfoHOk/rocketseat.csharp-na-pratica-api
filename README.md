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

- adicionar nuget package: dotnet add CloudStorageSolution.Infrastructure package Google.Apis.Drive.v3 --version 1.67.0.3309

- adicionar nuget package: dotnet add CloudStorageSolution.Application package dotenv.net --version 3.1.3

- adicionar reference: dotnet add CloudStorageSolution.Api/CloudStorageSolution.Api.csproj reference CloudStorageSolution.Infrastructure/CloudStorageSolution.Infrastructure.csproj

- adicionar nuget package: dotnet add CloudStorageSolution.Api package dotenv.net --version 3.1.3

## Google Cloud Console

- https://console.cloud.google.com/welcome?organizationId=0

- Selecione um projeto ->
- Novo projeto ->
- Preencher formulário, Criar ->
- Selecionar projeto ->
- Menu -> Apis e serviços - Credenciais ->
- Configurar tela de consentimento ->
- Externo, Criar ->
- Preencher formulário, Salvar e continuar ->
- Salvar e continuar ->
- Salvar e continuar ->
- Voltar para o painel ->
- Biblioteca ->
- Pesquisar, Google Drive API ->
- Google Drive API ->
- Ativar ->
- Credenciais ->
- Criar credenciais -> Id do client OAuth ->
- Tipo de aplicativo, Aplicativo da Web ->
- Preencher formulário, Criar ->
- Copiar: Id do cliente e chave secreta do cliente, Ok ->
- Apis e serviços - Tela de permissão OAuth ->
- Usuários de teste - Add users ->
- Preencher com email, Salvar ->
- Apis e serviços - Credenciais ->
- IDs do cliente OAuth 2.0 - nome_do_client_criado ->
- URIs de redirecionamento autorizados - Adicionar uri ->
- Preencher com https://developers.google.com/oauthplayground, Salvar ->

## OAuth 2.0 Playground

- https://developers.google.com/oauthplayground

- OAuth 2.0 Configuration (ícone de engrenagem) ->
- Use your own OAuth credentials ->
- Preencher formulário, Close ->
- Select: Drive API v3, Selecionar todas as sub opções, Authorize Apis ->
- Fazer login do Google, Continuar ->
- Selecionar tudo -> Continuar ->
- Exchange authorization code for tokens ->
- Copiar: access_token e refresh_token
