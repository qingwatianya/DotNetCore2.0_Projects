FROM microsoft/dotnet-framework:4.6.2
ARG source
WORKDIR /app
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["C:\app\Console_PostSharp_Test.exe"]
