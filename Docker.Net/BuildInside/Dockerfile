FROM mcr.microsoft.com/dotnet/sdk:8.0 AS publish
WORKDIR /src
COPY . . 
RUN ["ls"]
RUN dotnet restore Docker.Net --locked-mode
RUN dotnet publish Docker.Net -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=publish /app/publish .
RUN ["ls"]
RUN ["chmod", "+x", "Docker.Net"]
ENTRYPOINT ["./Docker.Net"]