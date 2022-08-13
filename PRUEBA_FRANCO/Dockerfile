#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PRUEBA_FRANCO/PRUEBA_FRANCO.csproj", "PRUEBA_FRANCO/"]
RUN dotnet restore "PRUEBA_FRANCO/PRUEBA_FRANCO.csproj"
COPY . .
WORKDIR "/src/PRUEBA_FRANCO"
RUN dotnet build "PRUEBA_FRANCO.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PRUEBA_FRANCO.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PRUEBA_FRANCO.dll"]