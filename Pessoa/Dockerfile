#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base

ENV ASPNETCORE_URLS=http://*:443
ENV ASPNETCORE_ENVIRONMENT="production"

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Pessoa/Pessoa.csproj", "Pessoa/"]
RUN dotnet restore "Pessoa/Pessoa.csproj"
COPY . .
WORKDIR "/src/Pessoa"
RUN dotnet build "Pessoa.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pessoa.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pessoa.dll"]
