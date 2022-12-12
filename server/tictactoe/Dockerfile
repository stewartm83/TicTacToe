FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["tictactoe/tictactoe.csproj", "tictactoe/"]
RUN dotnet restore "tictactoe/tictactoe.csproj"
COPY . .
WORKDIR "/src/tictactoe"
RUN dotnet build "tictactoe.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "tictactoe.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "tictactoe.dll"]
