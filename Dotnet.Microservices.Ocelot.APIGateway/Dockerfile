#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Dotnet.Microservices.Ocelot.APIGateway/Dotnet.Microservices.Ocelot.APIGateway.csproj", "Dotnet.Microservices.Ocelot.APIGateway/"]
RUN dotnet restore "Dotnet.Microservices.Ocelot.APIGateway/Dotnet.Microservices.Ocelot.APIGateway.csproj"
COPY . .
WORKDIR "/src/Dotnet.Microservices.Ocelot.APIGateway"
RUN dotnet build "Dotnet.Microservices.Ocelot.APIGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dotnet.Microservices.Ocelot.APIGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dotnet.Microservices.Ocelot.APIGateway.dll"]