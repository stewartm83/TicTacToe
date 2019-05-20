FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["tictactoe-server/tictactoe-server.csproj", "tictactoe-server/"]
RUN dotnet restore "tictactoe-server/tictactoe-server.csproj"
COPY . .
WORKDIR "/src/tictactoe-server"
RUN dotnet build "tictactoe-server.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "tictactoe-server.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "tictactoe-server.dll"]