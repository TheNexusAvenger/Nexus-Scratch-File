# TheNexusAvenger
#
# Simple script for creating release binaries.

export DOTNET_VERSION=net7.0

# Clear the existing releases.
rm -rf ./bin/
mkdir ./bin

# Create the Windows release.
dotnet publish -c release -r win-x64 ./Nexus.Scratch.File/Nexus.Scratch.File.csproj
cp ./Nexus.Scratch.File/bin/Release/${DOTNET_VERSION}/win-x64/publish/Nexus.Scratch.File.exe ./bin/NexusScratchFile-win-x64.exe

# Create the macOS release.
dotnet publish -c release -r osx-x64 ./Nexus.Scratch.File/Nexus.Scratch.File.csproj
cp ./Nexus.Scratch.File/bin/Release/${DOTNET_VERSION}/osx-x64/publish/Nexus.Scratch.File ./bin/NexusScratchFile-macos-x64

# Create the Linux release.
dotnet publish -c release -r linux-x64 ./Nexus.Scratch.File/Nexus.Scratch.File.csproj
cp ./Nexus.Scratch.File/bin/Release/${DOTNET_VERSION}/linux-x64/publish/Nexus.Scratch.File ./bin/NexusScratchFile-linux-x64