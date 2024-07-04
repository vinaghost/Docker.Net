FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . . 
RUN ["ls"]
RUN dotnet restore Docker.Net --locked-mode
RUN dotnet build Docker.Net -c Release -o /app/build --no-restore

FROM build AS publish
RUN dotnet publish Docker.Net -c Release -o /app/publish -p:PublishSingleFile=true --no-build

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=publish /app/publish .
RUN ["ls"]
RUN ["chmod", "+x", "Docker.Net"]
ENTRYPOINT ["./Docker.Net"]