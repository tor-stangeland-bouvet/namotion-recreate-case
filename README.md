# Overview

This is a simple solution to recreate bug with XML documentation not found on Mac OS X.
The solution contains a simple class library containing a class with a XML doc-string,
and a simple application that outputs the name and XML doc-string summary to the console.

## Prerequisites

1. Git installed
2. `dotnet` SDK installed (<https://dotnet.microsoft.com/en-us/download>)

## Setup

1. Checkout the `Namotion.Reflection` repository. Either:
    - main repo: <https://github.com/RicoSuter/Namotion.Reflection.git> (for verifying failure)
    - forked repo: <https://github.com/tor-stangeland-bouvet/Namotion.Reflection.git> (for verifying success)
2. Checkout this repository (in the same top-level folder)

After this you should have two folders:

- `Namotion.Reflection`
- `namotion-recreate-case`

## How to run

From the root folder of this repository, run the steps described below.

Step 1 - build class library:

```shell
dotnet build ./ClassLibrary/ClassLibrary.csproj
```

Step 2 - run application

```shell
dotnet run --project ./ConsoleApp/ConsoleApp.csproj -- ./ClassLibrary/bin/Debug/net8.0/ClassLibrary.dll
```

Expected output:

```text
Class1
Summary doc comment
```
