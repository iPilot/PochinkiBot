FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /app
COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:3.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

RUN apk update
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT false
ENV LC_ALL ru_RU.UTF-8
ENV LANGUAGE ru_RU.UTF-8
ENV LANG ru_RU.UTF-8

ENTRYPOINT ["dotnet", "PochinkiBot.dll"]