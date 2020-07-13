#!/bin/sh

cd $(dirname $0)
dotnet R7.Applicants.Tests.dll --path=$HOME/Рабочий\ стол/My\ Workspace/R7.Applicants/real-data
