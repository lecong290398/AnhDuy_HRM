#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/AnhDuyCompany.ManagerCompany.Migrator/AnhDuyCompany.ManagerCompany.Migrator.csproj", "src/AnhDuyCompany.ManagerCompany.Migrator/"]
COPY ["src/AnhDuyCompany.ManagerCompany.EntityFrameworkCore/AnhDuyCompany.ManagerCompany.EntityFrameworkCore.csproj", "src/AnhDuyCompany.ManagerCompany.EntityFrameworkCore/"]
COPY ["src/AnhDuyCompany.ManagerCompany.Core/AnhDuyCompany.ManagerCompany.Core.csproj", "src/AnhDuyCompany.ManagerCompany.Core/"]
COPY ["src/AnhDuyCompany.ManagerCompany.Core.Shared/AnhDuyCompany.ManagerCompany.Core.Shared.csproj", "src/AnhDuyCompany.ManagerCompany.Core.Shared/"]
RUN dotnet restore "src/AnhDuyCompany.ManagerCompany.Migrator/AnhDuyCompany.ManagerCompany.Migrator.csproj"
COPY . .
WORKDIR "/src/src/AnhDuyCompany.ManagerCompany.Migrator"
RUN dotnet build "AnhDuyCompany.ManagerCompany.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AnhDuyCompany.ManagerCompany.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AnhDuyCompany.ManagerCompany.Migrator.dll", "-s"]
