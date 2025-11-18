# Use official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies first
COPY Auth.Core/Auth.Core.csproj Auth.Core/
COPY Auth.Infrastructure/Auth.Infrastructure.csproj Auth.Infrastructure/
COPY Auth.Api/Auth.Api.csproj Auth.Api/

# Restore dependencies
RUN dotnet restore Auth.Api/Auth.Api.csproj

# Copy the rest of the files
COPY Auth.Core/ Auth.Core/
COPY Auth.Infrastructure/ Auth.Infrastructure/
COPY Auth.Api/ Auth.Api/

# Build the project
RUN dotnet publish Auth.Api/Auth.Api.csproj -c Release -o out

# Use runtime image for smaller final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 (can be changed)
EXPOSE 80

# Set environment variable for production
ENV DOTNET_ENVIRONMENT=Production

# Start the application
ENTRYPOINT ["dotnet", "Auth.Api.dll"]