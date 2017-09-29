FROM microsoft/aspnetcore:2.0
ARG source
WORKDIR /app
EXPOSE 8080
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "DotNetCore2.0_Web_Application_WithDocker.dll"]
