#!/bin/bash

export ASPNETCORE_ENVIRONMENT=Development
export DOTNET_WATCH_SUPPRESS_EMOJIS=1
export DOTNET_WATCH_RESTART_ON_RUDE_EDIT=1
export DOTNET_WATCH_SUPPRESS_LAUNCH_BROWSER=1

dotnet watch --project src/Sharpy.csproj # --non-interactive
