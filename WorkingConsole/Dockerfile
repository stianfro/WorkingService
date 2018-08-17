FROM microsoft/dotnet:2.1-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY WorkingConsole/WorkingConsole.csproj WorkingConsole/
COPY WorkingLibrary/WorkingLibrary.csproj WorkingLibrary/
RUN dotnet restore WorkingConsole/WorkingConsole.csproj
COPY . .
WORKDIR /src/WorkingConsole
RUN dotnet build WorkingConsole.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WorkingConsole.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WorkingConsole.dll"]
