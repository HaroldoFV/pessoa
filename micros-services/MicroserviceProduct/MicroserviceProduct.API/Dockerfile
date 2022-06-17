FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MicroserviceProduct.API/MicroserviceProduct.API.csproj", "MicroserviceProduct.API/"]
RUN dotnet restore "MicroserviceProduct.API/MicroserviceProduct.API.csproj"
COPY . .
WORKDIR "/src/MicroserviceProduct.API"
RUN dotnet build "MicroserviceProduct.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroserviceProduct.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroserviceProduct.API.dll"]
