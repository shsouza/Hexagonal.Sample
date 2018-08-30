FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 51222
EXPOSE 44372

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Hexagonal.WebApi/Hexagonal.WebApi.csproj", "Hexagonal.WebApi/"]
RUN dotnet restore "Hexagonal.WebApi/Hexagonal.WebApi.csproj"
COPY . .
WORKDIR "/src/Hexagonal.WebApi"
RUN dotnet build "Hexagonal.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Hexagonal.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Hexagonal.WebApi.dll"]