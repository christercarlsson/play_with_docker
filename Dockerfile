# escape=`
# Build stage
FROM microsoft/aspnetcore-build:2 AS builder
WORKDIR /src
COPY ./src/tinywebapp.csproj .
RUN dotnet restore
COPY ./src .
RUN dotnet build
RUN dotnet publish -o /publish

# Publish stage
FROM microsoft/aspnetcore:2 AS worker
WORKDIR /app
COPY --from=builder /publish .
ENTRYPOINT [ "dotnet", "tinywebapp.dll" ]