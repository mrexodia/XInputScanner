# XInputScanner

XInputScanner is a simple tool that tries to figure out how to name your `xinput` DLL file for [x360ce](http://www.x360ce.com).

![screenshot](http://i.imgur.com/TGflGxW.png)

## Features

- Scan a single file
- Scan a directory (optionally with subdirectories)
- Drag & Drop support (for both directories and files)

A directory scan only searches in DLL and EXE files. Scanning different file types is supported, but only when scanning a single file.

## Compiling

1. Clone the project (make sure to [clone submodules](http://stackoverflow.com/questions/3796927/how-to-git-clone-including-submodules));
2. Compile `Yara.NET\Yara.NET.sln` in `Release\Win32` mode;
3. Compile `XInputScanner.sln`;
4. Have fun!

## Contributing

I consider this project finished, but I'll gladly merge any pull request. 