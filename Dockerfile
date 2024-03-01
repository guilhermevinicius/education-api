FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
COPY . .
WORKDIR ./Education.Api

RUN dotnet clean
RUN dotnet restore ./Education.Api.csproj
RUN dotnet build ./Education.Api.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish ./Education.Api.csproj -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Education.Api.dll"]
