
FROM microsoft/dotnet:2.2.0-aspnetcore-runtime AS base

# ENV TZ=Asia/Bangkok
# RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

WORKDIR /app
COPY .publish/W /app
RUN rm /app/appsettings.json

ENTRYPOINT ["dotnet", "WebApi.dll"]