FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /build
COPY src /build
RUN dotnet restore BuildMultistage.csproj
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["./BuildMultistage"]

COPY --from=builder /app .