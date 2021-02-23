#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY IS413Assignment5Real/IS413Assignment5Real.csproj IS413Assignment5Real/
RUN dotnet restore "IS413Assignment5Real/IS413Assignment5Real.csproj"
COPY . .
WORKDIR "/src/IS413Assignment5Real"
RUN dotnet build "IS413Assignment5Real.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IS413Assignment5Real.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IS413Assignment5Real.dll"]
