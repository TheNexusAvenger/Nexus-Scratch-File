# Nexus Scratch File
Nexus Scratch File is a simple command line utility for creating
starter Roblox Studio files. This was created in response to
[Roblox Studio now only creating places with Team Create on](https://devforum.roblox.com/t/beta-new-experiences-have-team-create-enabled/2019729).

Many developers use baseplates as scratch/working files to
work on a small feature off of a main game due to complications
with working directly on the main game. Creating new places
every time this is done leads to hundreds of new places cluttering
the place list on Roblox.

## Usage
Nexus Scratch File is meant to be used in the command line.
It can accept a file name (can be a full path) and will create
a RBXL file with that path. If none is specified, `Baseplate`
is used instead.

```
C:\CURRENT\WORKING\PATH> NexusScratchFile-win-x64.exe
Created scratch file C:\CURRENT\WORKING\PATH\Baseplate.rbxl

C:\CURRENT\WORKING\PATH> NexusScratchFile-win-x64.exe MyFileName
Created scratch file C:\CURRENT\WORKING\PATH\MyFileName.rbxl

C:\CURRENT\WORKING\PATH> NexusScratchFile-win-x64.exe C:\Somewhere\MyFileName
Created scratch file C:\Somewhere\MyFileName
```

Similar to Windows, numbers will be added if the file already exists.
```
C:\CURRENT\WORKING\PATH> NexusScratchFile-win-x64.exe MyFileName
Created scratch file C:\CURRENT\WORKING\PATH\MyFileName.rbxl
C:\CURRENT\WORKING\PATH> NexusScratchFile-win-x64.exe MyFileName
Created scratch file C:\CURRENT\WORKING\PATH\MyFileName (1).rbxl
C:\CURRENT\WORKING\PATH> NexusScratchFile-win-x64.exe MyFileName
Created scratch file C:\CURRENT\WORKING\PATH\MyFileName (2).rbxl
```

## Linux/macOS Binaries
For Linux and macOS binaries, remember to run `chmod +x` on
the binary to make them executable.

## Contributing
Both issues and pull requests are accepted for this project.

## License
Nexus Scratch File is available under the terms of the MIT 
Licence. See [LICENSE](LICENSE) for details.