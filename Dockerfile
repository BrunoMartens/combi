# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Angular stage
FROM node:22-alpine as angular

WORKDIR /app
COPY ./Combi.Angular/package.json ./
RUN npm i && npm cache clean --force
COPY ./Combi.Angular/. .
RUN npm run build

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Combi.Web/Combi.Web.csproj", "Combi.Web/"]
RUN dotnet restore "./Combi.Web/Combi.Web.csproj"
COPY . .
WORKDIR "/src/Combi.Web"
RUN dotnet build "./Combi.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Combi.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=angular /app/dist/combi/browser ./wwwroot
ENTRYPOINT ["dotnet", "Combi.Web.dll"]