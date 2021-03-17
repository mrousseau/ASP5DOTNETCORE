#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["TestVsWebMvc3.1/TestVsWebMvc3.1.csproj", "TestVsWebMvc3.1/"]
RUN dotnet restore "TestVsWebMvc3.1/TestVsWebMvc3.1.csproj"
COPY . .
WORKDIR "/src/TestVsWebMvc3.1"
RUN dotnet build "TestVsWebMvc3.1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestVsWebMvc3.1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestVsWebMvc3.1.dll"]