#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ProjHexag.Api/ProjHexag.Api.csproj", "ProjHexag.Api/"]
COPY ["ProjHexag.Domain/ProjHexag.Domain.csproj", "ProjHexag.Domain/"]
RUN dotnet restore "ProjHexag.Api/ProjHexag.Api.csproj"
COPY . .
WORKDIR "/src/ProjHexag.Api"
RUN dotnet build "ProjHexag.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjHexag.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjHexag.Api.dll"]