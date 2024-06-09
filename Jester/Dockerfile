

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Jester.csproj", "Jester/"]
RUN dotnet restore "Jester/Jester.csproj"
COPY . ./Jester

WORKDIR "/src/Jester"
RUN dotnet build "Jester.csproj" -c Release -o /app/build

## Node Build Stage
FROM node:lts-alpine AS node_build
WORKDIR /frontend

COPY ./UI/ ./UI/
COPY ./Views ./Views
COPY ./ViewComponents ./ViewComponents

WORKDIR /frontend/UI
RUN npm install
RUN npm rebuild node-sass
RUN npm run build

FROM build AS publish
RUN dotnet publish "Jester.csproj" -c Release -o /app/publish

## Copy built UI assets from node_build stage
COPY --from=node_build /frontend/wwwroot /app/publish/wwwroot

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Jester.dll"]