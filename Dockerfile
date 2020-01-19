FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
COPY Player/bin/Release/netcoreapp2.1/publish/ Player/

ENTRYPOINT ["dotnet", "Player/Player.dll"]