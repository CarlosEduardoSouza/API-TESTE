FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Compugraf.API/Compugraf.API.csproj", "Compugraf.API/"]
RUN dotnet restore "Compugraf.API/Compugraf.API.csproj"
COPY . .
WORKDIR "/src/Compugraf.API"
RUN dotnet build "Compugraf.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Compugraf.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Compugraf.API.dll"]