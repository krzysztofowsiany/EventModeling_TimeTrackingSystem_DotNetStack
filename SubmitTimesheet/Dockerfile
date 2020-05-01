FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src/

COPY /*.csproj ./
RUN dotnet restore

COPY /src/. ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:2.1
WORKDIR /src/
COPY --from=build-env /src/out .
EXPOSE 8080
ENTRYPOINT ["dotnet", "SubmitTimeseheet.dll"]