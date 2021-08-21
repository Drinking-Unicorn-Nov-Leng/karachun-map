#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["karachun_map.API/karachun_map.API.API/karachun_map.API.API.csproj", "karachun_map.API/karachun_map.API.API/"]
COPY ["karachun_map.API/karachun_map.API.BI/karachun_map.API.BI.csproj", "karachun_map.API/karachun_map.API.BI/"]
COPY ["karachun_map.API/karachun_map.API.Data/karachun_map.API.Data.csproj", "karachun_map.API/karachun_map.API.Data/"]
COPY ["karachun_map.API/karachun_map.API.General/karachun_map.API.General.csproj", "karachun_map.API/karachun_map.API.General/"]
RUN dotnet restore "karachun_map.API/karachun_map.API.API/karachun_map.API.API.csproj"
COPY . .
WORKDIR "/src/karachun_map.API/karachun_map.API.API"
RUN dotnet build "karachun_map.API.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "karachun_map.API.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "karachun_map.API.API.dll"]