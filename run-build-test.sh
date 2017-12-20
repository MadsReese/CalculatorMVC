#!/bin/bash
dotnet restore
dotnet build
dotnet test ./Calculator.Unit/
#dotnet test ./Calculator.Selenium/
