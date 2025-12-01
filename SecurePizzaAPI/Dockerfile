# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Kopiera csproj och restore dependencies
COPY ["SecurePizzaAPI.csproj", "./"]
RUN dotnet restore "SecurePizzaAPI.csproj"

# Kopiera all kod och builda
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
ENTRYPOINT ["dotnet", "SecurePizzaAPI.dll"]
