FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Whisper.Auth/Whisper.Auth.csproj", "Whisper.Auth/"]
RUN dotnet restore "./Whisper.Auth/Whisper.Auth.csproj"
COPY . .
WORKDIR "/src/Whisper.Auth"
RUN dotnet build "./Whisper.Auth.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Whisper.Auth.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Whisper.Auth.dll"]