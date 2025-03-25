# Stage 1: Build ứng dụng
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy toàn bộ mã nguồn vào container
COPY . ./

# Restore và publish ứng dụng
RUN dotnet restore
RUN dotnet publish -c Release -o /out

# Stage 2: Runtime để chạy ứng dụng
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy file đã build từ stage 1
COPY --from=build /out .

# Chạy ứng dụng
ENTRYPOINT ["dotnet", "shopping-api.dll"]
