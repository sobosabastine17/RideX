FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5273

ENV ASPNETCORE_URLS=http://+:5273

USER app

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src

# Explicitly copy the project file
#COPY RideX/RideX.csproj RideX/
COPY *.csproj ./
RUN dotnet restore 

COPY . ./
#WORKDIR "/src/RideX"
RUN dotnet build -c $configuration -o /app/build
#RUN dotnet build -c Release -o out 

FROM build AS publish
ARG configuration=Release
RUN dotnet publish -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RideX.dll"]
