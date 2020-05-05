FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src/

RUN apt-get update -y
RUN curl -sL https://deb.nodesource.com/setup_10.x | bash --debug
RUN apt-get install nodejs -yq


COPY /src/*.csproj ./
RUN dotnet restore

COPY /src ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /
COPY --from=build /src/out /

EXPOSE 80

ENTRYPOINT ["dotnet", "HourlyRate.dll"]