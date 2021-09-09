#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["IncrementSequenceTest/IncrementSequenceTest.csproj", "IncrementSequenceTest/"]
COPY ["IncrementSequenceApi/IncrementSequenceApi.csproj", "IncrementSequenceApi/"]
RUN dotnet restore "IncrementSequenceTest/IncrementSequenceTest.csproj"
COPY . .
WORKDIR "/src/IncrementSequenceTest"
RUN dotnet build "IncrementSequenceTest.csproj" -c Release -o /app/build

WORKDIR "/app/build"
ENTRYPOINT ["dotnet","test","IncrementSequenceTest.dll"]