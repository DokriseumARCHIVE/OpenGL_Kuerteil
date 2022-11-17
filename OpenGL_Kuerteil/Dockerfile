FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OpenGL_Kuerteil/OpenGL_Kuerteil.csproj", "OpenGL_Kuerteil/"]
RUN dotnet restore "OpenGL_Kuerteil/OpenGL_Kuerteil.csproj"
COPY . .
WORKDIR "/src/OpenGL_Kuerteil"
RUN dotnet build "OpenGL_Kuerteil.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenGL_Kuerteil.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenGL_Kuerteil.dll"]
