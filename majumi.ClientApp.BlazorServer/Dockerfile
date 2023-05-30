#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

EXPOSE 5100

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["majumi.ClientApp.BlazorServer/majumi.ClientApp.BlazorServer.csproj", "majumi.ClientApp.BlazorServer/"]
COPY ["majumi.ClientApp.Controller/majumi.ClientApp.Controller.csproj", "majumi.ClientApp.Controller/"]
COPY ["majumi.ClientApp.Utilities/majumi.ClientApp.Utilities.csproj", "majumi.ClientApp.Utilities/"]
COPY ["majumi.ClientApp.Model/majumi.ClientApp.Model.csproj", "majumi.ClientApp.Model/"]
COPY ["majumi.ClientApp.Tests/majumi.ClientApp.Tests.csproj", "majumi.ClientApp.Tests/"]
RUN dotnet restore "majumi.ClientApp.BlazorServer/majumi.ClientApp.BlazorServer.csproj"
COPY . .
WORKDIR "/src/majumi.ClientApp.BlazorServer"
RUN dotnet build "majumi.ClientApp.BlazorServer.csproj" -c Production -o /app/build

FROM build AS publish
RUN dotnet publish "majumi.ClientApp.BlazorServer.csproj" -c Production -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "majumi.ClientApp.BlazorServer.dll"]