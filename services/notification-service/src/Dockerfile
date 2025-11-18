# Use official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies first
COPY Notification.Core/Notification.Core.csproj Notification.Core/
COPY Notification.Infrastructure/Notification.Infrastructure.csproj Notification.Infrastructure/
COPY Notification.Api/Notification.Api.csproj Notification.Api/

# Restore dependencies
RUN dotnet restore Notification.Api/Notification.Api.csproj

# Copy the rest of the files
COPY Notification.Core/ Notification.Core/
COPY Notification.Infrastructure/ Notification.Infrastructure/
COPY Notification.Api/ Notification.Api/

# Build the project
RUN dotnet publish Notification.Api/Notification.Api.csproj -c Release -o out

# Use runtime image for smaller final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 (can be changed)
EXPOSE 80

# Set environment variable for production
ENV DOTNET_ENVIRONMENT=Production

# Start the application
ENTRYPOINT ["dotnet", "Notification.Api.dll"]