FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WorkerService1/WorkerService1.csproj", "WorkerService1/"]
RUN dotnet restore "WorkerService1/WorkerService1.csproj"
COPY . .
WORKDIR "/src/WorkerService1"
RUN dotnet build "WorkerService1.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "WorkerService1.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

EXPOSE 80

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrotiNative.WorkerService1.dll"]

## to build: 
#docker build -t troti1 -f WorkerService1/Dockerfile .

## to run:
#docker run -d -p 5001:80 --name WorkerService1 -e ASPNETCORE_ENVIRONMENT=Development troti1