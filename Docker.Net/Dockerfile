FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY bin/Docker.Net/ ./
RUN ["rm", "appsettings.json"]
RUN ["chmod", "+x", "Docker.Net"]
ENTRYPOINT ["./Docker.Net"]