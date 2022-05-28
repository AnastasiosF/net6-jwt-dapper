FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["net6-jwt-dapper/net6-jwt-dapper.csproj", "net6-jwt-dapper/"]
RUN dotnet restore "net6-jwt-dapper/net6-jwt-dapper.csproj"
COPY . .
WORKDIR "/src/net6-jwt-dapper"
RUN dotnet build "net6-jwt-dapper.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "net6-jwt-dapper.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "net6-jwt-dapper.dll"]
