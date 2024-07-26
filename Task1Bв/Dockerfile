FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Task1Bв/Task1Bв.csproj", "Task1Bв/"]
RUN dotnet restore "Task1Bв/Task1Bв.csproj"
COPY . .
WORKDIR "/src/Task1Bв"
RUN dotnet build "Task1Bв.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task1Bв.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task1Bв.dll"]
