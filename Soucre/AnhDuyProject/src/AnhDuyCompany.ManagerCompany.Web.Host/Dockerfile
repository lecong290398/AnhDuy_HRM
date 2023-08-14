#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/AnhDuyCompany.ManagerCompany.Web.Host/AnhDuyCompany.ManagerCompany.Web.Host.csproj", "src/AnhDuyCompany.ManagerCompany.Web.Host/"]
COPY ["src/AnhDuyCompany.ManagerCompany.Web.Core/AnhDuyCompany.ManagerCompany.Web.Core.csproj", "src/AnhDuyCompany.ManagerCompany.Web.Core/"]
COPY ["src/AnhDuyCompany.ManagerCompany.Application/AnhDuyCompany.ManagerCompany.Application.csproj", "src/AnhDuyCompany.ManagerCompany.Application/"]
COPY ["src/AnhDuyCompany.ManagerCompany.Application.Shared/AnhDuyCompany.ManagerCompany.Application.Shared.csproj", "src/AnhDuyCompany.ManagerCompany.Application.Shared/"]
COPY ["src/AnhDuyCompany.ManagerCompany.Core.Shared/AnhDuyCompany.ManagerCompany.Core.Shared.csproj", "src/AnhDuyCompany.ManagerCompany.Core.Shared/"]
COPY ["src/AnhDuyCompany.ManagerCompany.Core/AnhDuyCompany.ManagerCompany.Core.csproj", "src/AnhDuyCompany.ManagerCompany.Core/"]
COPY ["src/AnhDuyCompany.ManagerCompany.EntityFrameworkCore/AnhDuyCompany.ManagerCompany.EntityFrameworkCore.csproj", "src/AnhDuyCompany.ManagerCompany.EntityFrameworkCore/"]
COPY ["src/AnhDuyCompany.ManagerCompany.GraphQL/AnhDuyCompany.ManagerCompany.GraphQL.csproj", "src/AnhDuyCompany.ManagerCompany.GraphQL/"]
RUN dotnet restore "src/AnhDuyCompany.ManagerCompany.Web.Host/AnhDuyCompany.ManagerCompany.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/AnhDuyCompany.ManagerCompany.Web.Host"
RUN dotnet build "AnhDuyCompany.ManagerCompany.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AnhDuyCompany.ManagerCompany.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AnhDuyCompany.ManagerCompany.Web.Host.dll"]
