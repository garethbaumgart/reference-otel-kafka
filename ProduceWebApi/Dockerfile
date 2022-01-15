#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ProduceWebApi/ProduceWebApi.csproj", "ProduceWebApi/"]
RUN dotnet restore "ProduceWebApi/ProduceWebApi.csproj"
COPY . .
WORKDIR "/src/ProduceWebApi"
RUN dotnet build "ProduceWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProduceWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProduceWebApi.dll"]