# Use official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies first
COPY ../RFQ.Core/RFQ.Core.csproj ../RFQ.Core/
COPY ../RFQ.Infrastructure/RFQ.Infrastructure.csproj ../RFQ.Infrastructure/
COPY RFQ.Api.csproj ./
RUN dotnet restore

# Copy the rest of the files
COPY ../RFQ.Core ../RFQ.Core
COPY ../RFQ.Infrastructure ../RFQ.Infrastructure
COPY . ./

# Build the project
RUN dotnet publish -c Release -o out

# Use runtime image for smaller final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 (can be changed)
EXPOSE 80

# Set environment variable for production
ENV DOTNET_ENVIRONMENT=Production

# Start the application
ENTRYPOINT ["dotnet", "RFQ.Api.dll"]