---
title: Compiling
parent: Introduction
nav_order: 1
---

# Compiling 

### Prerequisites

To compile saor you will need the latest Cosmos Dev Kit. For installing the kit, check out Cosmos documentation check it out [here](https://cosmosos.github.io/articles/Installation/DevKit.html).

You can use any IDE to develop saor. Or if you need only to compile, you don't need to use a IDE at all.

Some IDEs compatible with C# are listed down there:

- [Visual Studio](https://visualstudio.microsoft.com/) (Windows)
- [Visual Studio Code](https://code.visualstudio.com/) (Windows - MacOS - Linux)
- [JetBrains Rider](https://www.jetbrains.com/rider/) (Windows - MacOS - Linux)
- [Mono](https://www.mono-project.com/) (Windows - MacOS - Linux)

### Visual Studio (Windows) 

After opening the solution, to compile saor using Visual Studio just hit "Compile solution" in the Visual Studio menu (sorry if the screenshot is in italian lol)

![Compilation on Visual Studio](https://github.com/user-attachments/assets/818e4198-087d-4bf7-a00c-c3e2952af702)

### Every other platform

You can just compile from the command line using this command:

```sh
dotnet build .\saor.csproj
```

{: .note }
If you see some warnings in the compilation don't worry, it's completely normal.

After compiling there should be a /bin/ folder in your project folder, open it and depending on how you compiled you should find all the compilation files including `saor.iso` in the \Debug\net6.0\ or \cosmos\Debug\net6.0
