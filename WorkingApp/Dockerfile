FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY WorkingApp/WorkingApp.csproj WorkingApp/
RUN dotnet restore WorkingApp/WorkingApp.csproj
COPY . .
WORKDIR /src/WorkingApp
RUN dotnet build WorkingApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WorkingApp.csproj -c Release -o /app

FROM base AS final

# Create the home directory for the new app user.
RUN mkdir -p /home/app

# Create an app user so our program doesn't run as root.
RUN groupadd -r app &&\
    useradd -r -g app -d /home/app -s /sbin/nologin -c "Docker image user" app

# Set the home directory to our app user's home.
ENV HOME=/home/app
ENV APP_HOME=/home/app/workingservice

## SETTING UP THE APP ##
RUN mkdir $APP_HOME
WORKDIR $APP_HOME

COPY --from=publish $APP_HOME .
ENTRYPOINT ["dotnet", "WorkingApp.dll"]
