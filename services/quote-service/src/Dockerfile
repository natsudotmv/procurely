# Use official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies first
COPY Quote.Core/Quote.Core.csproj Quote.Core/
COPY Quote.Infrastructure/Quote.Infrastructure.csproj Quote.Infrastructure/
COPY Quote.Api/Quote.Api.csproj Quote.Api/

# Restore dependencies
RUN dotnet restore Quote.Api/Quote.Api.csproj

# Copy the rest of the files
COPY Quote.Core/ Quote.Core/
COPY Quote.Infrastructure/ Quote.Infrastructure/
COPY Quote.Api/ Quote.Api/

# Build the project
RUN dotnet publish Quote.Api/Quote.Api.csproj -c Release -o out

# Use runtime image for smaller final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 (can be changed)
EXPOSE 80

# Set environment variable for production
ENV DOTNET_ENVIRONMENT=Production

# Start the application
ENTRYPOINT ["dotnet", "Quote.Api.dll"]