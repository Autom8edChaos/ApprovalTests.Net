.nuget\NuGet.exe pack ApprovalUtilities\ApprovalUtilities.csproj -OutputDirectory .\ApprovalUtilities -Symbols -Build -Properties Configuration=Debug -Version %PackageVersion%
.nuget\NuGet.exe pack ApprovalTests\ApprovalTests.csproj -OutputDirectory .\ApprovalTests -Symbols -Build -Properties Configuration=Debug -Version %PackageVersion%