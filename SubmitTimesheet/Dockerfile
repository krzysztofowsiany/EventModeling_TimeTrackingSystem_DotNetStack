FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src/

RUN apt-get update -y
RUN curl -sL https://deb.nodesource.com/setup_10.x | bash --debug
RUN apt-get install nodejs -yq

COPY /*.csproj ./
RUN dotnet restore

COPY ./src ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:2.2
WORKDIR /src/
COPY --from=build /src/out .
EXPOSE 8080
ENTRYPOINT ["dotnet", "SubmitTimeseheet.dll"]