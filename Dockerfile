#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#https://jsonformatter.org/yaml-validator yml validator

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /FinancialInfoMs
EXPOSE 5135

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Financial_ms.csproj", "."]
RUN dotnet restore "./Financial_ms.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Financial_ms.csproj" -c Release -o /FinancialInfoMs/build

FROM build AS publish
RUN dotnet publish "Financial_ms.csproj" -c Release -o /FinancialInfoMs/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /FinancialInfoMs
COPY --from=publish /FinancialInfoMs/publish .
ENTRYPOINT ["dotnet", "Financial_ms.dll"]