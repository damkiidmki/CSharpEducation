FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CSharpEducation.Practice/CSharpEducation.Practice.csproj", "CSharpEducation.Practice/"]
RUN dotnet restore "CSharpEducation.Practice/CSharpEducation.Practice.csproj"
COPY . .
WORKDIR "/src/CSharpEducation.Practice"
RUN dotnet build "CSharpEducation.Practice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CSharpEducation.Practice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CSharpEducation.Practice.dll"]
