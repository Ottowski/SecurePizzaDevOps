# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# copy csproj and restore dependencies
COPY ["SecurePizzaAPI.csproj", "./"]
RUN dotnet restore "SecurePizzaAPI.csproj"

# copy all kod and build
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
ENTRYPOINT ["dotnet", "SecurePizzaAPI.dll"]
# run in http://localhost:8080/index.html