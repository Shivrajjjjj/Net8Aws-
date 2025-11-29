# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ./src/Net8Aws/Net8Aws.csproj ./Net8Aws/
RUN dotnet restore Net8Aws/Net8Aws.csproj

COPY ./src/Net8Aws ./Net8Aws/
RUN dotnet publish Net8Aws/Net8Aws.csproj -c Release -o /app/publish

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "Net8Aws.dll"]
