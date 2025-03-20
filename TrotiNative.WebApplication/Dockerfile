FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TrottiNative.WebApplication/TrottiNative.WebApplication.csproj", "TrottiNative.WebApplication/"]
RUN dotnet restore "TrottiNative.WebApplication/TrottiNative.WebApplication.csproj"
COPY . .
WORKDIR "/src/TrottiNative.WebApplication"
RUN dotnet build "TrottiNative.WebApplication.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "TrottiNative.WebApplication.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrottiNative.WebApplication.dll"]
