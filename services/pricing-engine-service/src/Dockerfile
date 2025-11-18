# Use official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies first
COPY Pricing.Core/Pricing.Core.csproj Pricing.Core/
COPY Pricing.Infrastructure/Pricing.Infrastructure.csproj Pricing.Infrastructure/
COPY Pricing.Api/Pricing.Api.csproj Pricing.Api/

# Restore dependencies
RUN dotnet restore Pricing.Api/Pricing.Api.csproj

# Copy the rest of the files
COPY Pricing.Core/ Pricing.Core/
COPY Pricing.Infrastructure/ Pricing.Infrastructure/
COPY Pricing.Api/ Pricing.Api/

# Build the project
RUN dotnet publish Pricing.Api/Pricing.Api.csproj -c Release -o out

# Use runtime image for smaller final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 (can be changed)
EXPOSE 80

# Set environment variable for production
ENV DOTNET_ENVIRONMENT=Production

# Start the application
ENTRYPOINT ["dotnet", "Pricing.Api.dll"]