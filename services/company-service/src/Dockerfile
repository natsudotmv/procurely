# Use official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies first
COPY Company.Core/Company.Core.csproj Company.Core/
COPY Company.Infrastructure/Company.Infrastructure.csproj Company.Infrastructure/
COPY Company.Api/Company.Api.csproj Company.Api/

# Restore dependencies
RUN dotnet restore Company.Api/Company.Api.csproj

# Copy the rest of the files
COPY Company.Core/ Company.Core/
COPY Company.Infrastructure/ Company.Infrastructure/
COPY Company.Api/ Company.Api/

# Build the project
RUN dotnet publish Company.Api/Company.Api.csproj -c Release -o out

# Use runtime image for smaller final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 (can be changed)
EXPOSE 80

# Set environment variable for production
ENV DOTNET_ENVIRONMENT=Production

# Start the application
ENTRYPOINT ["dotnet", "Company.Api.dll"]