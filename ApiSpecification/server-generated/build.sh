#!/usr/bin/env bash
#
# Generated by: https://openapi-generator.tech
#

dotnet restore src/DateTimeMicroservice.Server.OpenApiGenerated/ && \
    dotnet build src/DateTimeMicroservice.Server.OpenApiGenerated/ && \
    echo "Now, run the following to start the project: dotnet run -p src/DateTimeMicroservice.Server.OpenApiGenerated/DateTimeMicroservice.Server.OpenApiGenerated.csproj --launch-profile web"