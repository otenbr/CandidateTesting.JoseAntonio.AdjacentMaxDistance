# CandidateTesting.JoseAntonio.AdjacentMaxDistance

This Library encapsulate a function that returns the maximum distance between indexes of this array that have adjacent values.

-   The function returns −2 if no adjacent indexes exist.
-   The function accepts arrays of length of up to 40000 items.

## Getting Started

### Prerequisites

-   .Net Core 3.1 SDK
-   Visual Studio (_optional_)

### Building

Clone the repository to your machine.

```sh
git clone https://github.com/otenbr/CandidateTesting.JoseAntonio.AdjacentMaxDistance.git AdjacentMaxDistance
```

Change to solution directory and run the command `dotnet build`.

```sh
$ cd AdjacentMaxDistance
$ dotnet build

Microsoft (R) Build Engine version 16.5.0+d4cbfca49 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 43,43 ms for D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance\AdjacentMaxDistance.csproj.
  Restore completed in 44,71 ms for D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance.Tests\AdjacentMaxDistance.Tests.csproj.
  AdjacentMaxDistance -> D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance\bin\Debug\netcoreapp3.1\AdjacentMaxDistance.dll
  AdjacentMaxDistance.Tests -> D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance.Tests\bin\Debug\netcoreapp3.1\AdjacentMaxDistance.Tests.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.94
```

### Publishing

To publish a version for distribution, run the command `dotnet publish`. The package will be find in _\AdjacentMaxDistance\bin\Release\netcoreapp3.1\publish\AdjacentMaxDistance.dll_.

```sh
$ dotnet publish -c Release

Microsoft (R) Build Engine version 16.5.0+d4cbfca49 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 46 ms for D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance.Tests\AdjacentMaxDistance.Tests.csproj.
  Restore completed in 45,03 ms for D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance\AdjacentMaxDistance.csproj.
  AdjacentMaxDistance -> D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance\bin\Release\netcoreapp3.1\AdjacentMaxDistance.dll
  AdjacentMaxDistance -> D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance\bin\Release\netcoreapp3.1\publish\
  AdjacentMaxDistance.Tests -> D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance.Tests\bin\Release\netcoreapp3.1\AdjacentMaxDistance.Tests.dll
  AdjacentMaxDistance.Tests -> D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance.Tests\bin\Release\netcoreapp3.1\publish\
```

### Testing

To execute the unit tests, run the command `dotnet test`.

```sh
$ dotnet test

Test run for D:\Projects\dotnet\CandidateTesting.JoseAntonio\AdjacentMaxDistance\AdjacentMaxDistance.Tests\bin\Debug\netcoreapp3.1\AdjacentMaxDistance.Tests.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.5.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 5
     Passed: 5
 Total time: 1,0481 Seconds
```

### Usage

Copy the file _AdjacentMaxDistance.dll_ and add as reference in your project. Call the method `CandidateTesting.JoseAntonio.AdjacentMaxDistance.Solution(int[])`.

**Example:**

```csharp
...
using CandidateTesting.JoseAntonio.AdjacentMaxDistance;

...
class MyConsoleApp
{
	static void Main(string[] args)
	{
		int[] numbers = new int[] { 0, 3, 3, 12, 5, 3, 7, 1 };

		int maxDistance = AdjacentMaxDistance.Solution(numbers);

		Console.WriteLine("Max Distance: " + adjacentMaxDistance);
	}
}
...
```

```sh
$ MyConsoleApp

Max Distance: 5
```
