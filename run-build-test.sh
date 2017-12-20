#!/bin/bash
dotnet restore
dotnet test ./Calculator.Unit/
#dotnet test ./Calculator.Selenium/
