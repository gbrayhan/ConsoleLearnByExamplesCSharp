FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ConsoleLearnByExamples/ConsoleLearnByExamples.csproj", "ConsoleLearnByExamples/"]
RUN dotnet restore "ConsoleLearnByExamples/ConsoleLearnByExamples.csproj"
COPY . .
WORKDIR "/src/ConsoleLearnByExamples"
RUN dotnet build "ConsoleLearnByExamples.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleLearnByExamples.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleLearnByExamples.dll"]
