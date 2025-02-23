# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

# Set the working directory
WORKDIR /app

# Copy the project files
COPY . ./

# Restore dependencies
RUN dotnet restore

# Build the project
RUN dotnet publish -c Release -o out

# Use the official .NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0

# Set the working directory
WORKDIR /app

# Copy the build output
COPY --from=build-env /app/out .

# Expose the port the app runs on
EXPOSE 80

# Specify the entry point
ENTRYPOINT ["dotnet", "YourProjectName.dll"]