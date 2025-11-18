# Use official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies first
COPY Analytics.Core/Analytics.Core.csproj Analytics.Core/
COPY Analytics.Infrastructure/Analytics.Infrastructure.csproj Analytics.Infrastructure/
COPY Analytics.Api/Analytics.Api.csproj Analytics.Api/

# Restore dependencies
RUN dotnet restore Analytics.Api/Analytics.Api.csproj

# Copy the rest of the files
COPY Analytics.Core/ Analytics.Core/
COPY Analytics.Infrastructure/ Analytics.Infrastructure/
COPY Analytics.Api/ Analytics.Api/

# Build the project
RUN dotnet publish Analytics.Api/Analytics.Api.csproj -c Release -o out

# Use runtime image for smaller final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 (can be changed)
EXPOSE 80

# Set environment variable for production
ENV DOTNET_ENVIRONMENT=Production

# Start the application
ENTRYPOINT ["dotnet", "Analytics.Api.dll"]