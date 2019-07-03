
FROM microsoft/dotnet:2.2.0-aspnetcore-runtime AS base

# ENV TZ=Asia/Bangkok
# RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

WORKDIR /app
COPY .publish/W /app
RUN rm /app/appsettings.json

# HEALTHCHECK --interval=5s --timeout=3s CMD curl --fail http://localhost:8888/api/values || exit 1
HEALTHCHECK --interval=5s --timeout=3s CMD curl --fail http://localhost:80/api/values || exit 1

ENTRYPOINT ["dotnet", "WebApi.dll"]