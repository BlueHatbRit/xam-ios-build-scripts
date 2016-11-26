#!/bin/bash

if [ ! -f FAKE.4.4.4/tools/FAKE.exe ]
then
    echo "Installing FAKE..."
	mono --runtime=v4.0 tools/NuGet/nuget.exe install FAKE -Version 4.4.4
fi

echo "Running build..."
mono --runtime=v4.0 FAKE.4.4.4/tools/FAKE.exe build.fsx
