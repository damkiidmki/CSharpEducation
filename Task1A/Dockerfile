FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Task.CSharpBase/Task.CSharpBase.csproj", "Task.CSharpBase/"]
RUN dotnet restore "Task.CSharpBase/Task.CSharpBase.csproj"
COPY . .
WORKDIR "/src/Task.CSharpBase"
RUN dotnet build "Task.CSharpBase.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task.CSharpBase.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task.CSharpBase.dll"]
