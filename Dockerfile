# escape=`
FROM microsoft/aspnetcore-build:2 AS builder

WORKDIR /src

COPY ./src/tinywebapp.csproj .

RUN dotnet restore

COPY ./src .
RUN ls -laR

RUN dotnet build

RUN dotnet publish -o /publish

FROM microsoft/aspnetcore:2 AS worker

WORKDIR /app

COPY --from=builder /publish .
RUN ls -laR

ENTRYPOINT [ "dotnet", "tinywebapp.dll" ]