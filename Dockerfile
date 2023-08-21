
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5000

# Build runtime image
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
WORKDIR /src
COPY ["ProductsAPI.csproj", "./"]
RUN dotnet restore "ProductsAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ProductsAPI.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "ProductsAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProductsAPI.dll"]