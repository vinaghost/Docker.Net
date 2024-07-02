FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY bin/Docker.Net/ ./
RUN ["chmod", "+x", "Docker.Net"]
ENTRYPOINT ["./Docker.Net"]