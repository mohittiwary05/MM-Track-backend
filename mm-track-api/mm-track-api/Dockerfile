# -------------------
# Build stage
# -------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj files first and restore dependencies (faster caching)
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the project files
COPY . .

# Publish the project to /app folder
RUN dotnet publish -c Release -o /app

# -------------------
# Runtime stage
# -------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copy published files from build stage
COPY --from=build /app .

# Set environment variable and expose port
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Use the correct DLL name (adjust based on your actual output)
ENTRYPOINT ["dotnet", "mm_tract_api.dll"]
