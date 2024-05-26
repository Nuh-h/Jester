#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Jester/Jester.csproj", "Jester/"]
RUN dotnet restore "Jester/Jester.csproj"
COPY . .
WORKDIR "/src/Jester"
RUN dotnet build "Jester.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Jester.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Jester.dll"]