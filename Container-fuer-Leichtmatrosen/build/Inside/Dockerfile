FROM mcr.microsoft.com/dotnet/sdk:6.0
LABEL maintainer "frank@pommerening-online.de"
ENV REFRESHED_AT 2021-12-12

EXPOSE 80

COPY src /WebApp
WORKDIR /WebApp
RUN dotnet restore && dotnet build
ENTRYPOINT [ "dotnet", "run", "--no-restore", "--urls", "http://0.0.0.0:80"]
