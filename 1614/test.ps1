Write-Host  'Running the tests...' -ForegroundColor Magenta
Write-Host ''
dotnet test --nologo --logger "console;verbosity=detailed" .\MaximumNestingTest\MaximumNestingTest.csproj
