# Use official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies first
COPY Order.Core/Order.Core.csproj Order.Core/
COPY Order.Infrastructure/Order.Infrastructure.csproj Order.Infrastructure/
COPY Order.Api/Order.Api.csproj Order.Api/

# Restore dependencies
RUN dotnet restore Order.Api/Order.Api.csproj

# Copy the rest of the files
COPY Order.Core/ Order.Core/
COPY Order.Infrastructure/ Order.Infrastructure/
COPY Order.Api/ Order.Api/

# Build the project
RUN dotnet publish Order.Api/Order.Api.csproj -c Release -o out

# Use runtime image for smaller final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 (can be changed)
EXPOSE 80

# Set environment variable for production
ENV DOTNET_ENVIRONMENT=Production

# Start the application
ENTRYPOINT ["dotnet", "Order.Api.dll"]