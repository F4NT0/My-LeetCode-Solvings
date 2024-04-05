# ------------------------
# .NET PROJECT GENERATION
# ------------------------

# Define the solution
Write-Host '------------------------------'
Write-Host '  PROJECT CONSOLE GENERATOR   '
Write-Host '------------------------------'
Write-Host ''
Write-Host ''
Write-Host 'Enter the Solution name: ' -ForegroundColor Green
$solutionName = Read-Host '-> '
mkdir $solutionName
cd $solutionName
dotnet new sln --name $solutionName

# create a console project
Write-Host  'Enter the Project name: ' -ForegroundColor Yellow
$projectName = Read-Host '-> '
dotnet new console -o $projectName

# Add the project to the solution
Write-Host  'Adding the project into the solution... ' -ForegroundColor Blue
Write-Host ''
dotnet sln add $projectName/$projectName.csproj

# Create a test project
Write-Host ''
Write-Host  'Generating test project...' -ForegroundColor Yellow
Write-Host ''
$testProjectName = $projectName + 'Test'
dotnet new mstest -o $testProjectName

# Add the test project to the solution
Write-Host  'Adding the project test into the solution... ' -ForegroundColor Blue
Write-Host ''
dotnet sln add $testProjectName/$testProjectName.csproj

# Add a reference to the test project
Write-Host ''
Write-Host  'Adding the reference of the project into the project test... ' -ForegroundColor Blue
Write-Host ''
dotnet add $testProjectName/$testProjectName.csproj reference $projectName/$projectName.csproj

# ----------------------------------------
# ADD SIMPLE HELLO WORLD INTO THE PROJECT
# ----------------------------------------

Write-Host ''
Write-Host 'Adding Template code into the project...' -ForegroundColor DarkYellow
Write-Host ''
$code = @"
namespace $projectName
{
    public class Program
    {
      public static string GetHelloWorld()
      {
          return `"Hello World!`";
      }

      public static void Main(string[] args)
      {
          string test = GetHelloWorld();
          Console.WriteLine(test);
      }
    }
}
"@

$code | Out-File -FilePath $projectName/Program.cs

# --------------------------------
# ADD TESTS INTO THE TEST PROJECT
# --------------------------------

Write-Host 'Adding Template code into the project test...' -ForegroundColor DarkYellow
Write-Host ''
$testCode = @"
using Microsoft.VisualStudio.TestTools.UnitTesting;
using $projectName;

namespace $testProjectName;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestHelloWorld()
    {
        // Arrange
        //Program program = new Program();
        
        // Act
        string result = Program.GetHelloWorld();

        // Assert
        Assert.AreEqual("Hello World!", result);
    }
}
"@

$testCode | Out-File -FilePath $testProjectName/UnitTest1.cs

# ------------
# RUN PROJECT
# ------------
Write-Host  'Running the project...' -ForegroundColor Magenta
Write-Host ''
$projectCsproj = $projectName + '.csproj'
dotnet run --project $projectName/$projectCsproj

# -------------
# RUN THE TESTS
# --------------
Write-Host ''
Write-Host 'Running the tests...' -ForegroundColor Magenta
Write-Host ''
$testProjectCsproj = $testProjectName + '.csproj'
dotnet test $testProjectName/$testProjectCsproj

# ===========================
# CREATING THE DOCUMENTATION
# ===========================

Write-Host ''
Write-Host 'Creating Documentation...' -ForegroundColor Cyan
Write-Host ''
$solutionNameYml = $solutionName + '.yml'
$readme = @"
# $solutionName

Level: `$\color{lightgreen}{\sf Easy}$` OR `$\color{gold}{\sf Medium}$` OR `$\color{red}{\sf Hard}$`

Language: C#

Topic: $\color{yellow} \sf insert \space topic \space here$

Unit Tests: ![$solutionName - Testing Results](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/$solutionNameYml/badge.svg)](https://github.com/F4NT0/My-LeetCode-Solvings/actions/workflows/$solutionNameYml)

---

ADD HERE THE DESCRIPTION OF THE PROJECT AND EXAMPLES

"@

$readme | Out-File -FilePath README.md

# ======================
# TEST SCRIPT CREATION
# ======================

Write-Host ''
Write-Host 'Creating Test Script...' -ForegroundColor Cyan
Write-Host ''
$testScript = @"
Write-Host  'Running the tests...' -ForegroundColor Magenta
Write-Host ''
dotnet test --nologo --logger "console;verbosity=detailed" .\$testProjectName\$testProjectCsproj
"@

$testScript | Out-File -FilePath test.ps1

# =========================
# GITHUB WORKFLOW CREATION
# =========================

cd ..
cd .\.github\workflows\

Write-Host ''
Write-Host 'Creating Github Workflow...' -ForegroundColor Cyan
Write-Host ''
$workflowScript = @"
name: $solutionName - Testing Results

on:
  push:
    paths:
      - '$solutionName/**'

jobs:

  build:

    runs-on: windows-latest  # For a list of available runner types, refer to
                             # https://help.github.com/en/actions/reference/workflow-syntax-for-github-actions#jobsjob_idruns-on

    steps:
    - name: Checkout
      uses: actions/checkout@v4
      with:
        fetch-depth: 0

    # Install the .NET Core workload
    - name: Install .NET Core
      uses: actions/setup-dotnet@v4
      with:
        dotnet-version: 8.0.x

    # Add  MSBuild to the PATH: https://github.com/microsoft/setup-msbuild
    - name: Setup MSBuild.exe
      uses: microsoft/setup-msbuild@v2

    # Execute all unit tests in the solution
    - name: Execute Unit Tests
      run: dotnet test --nologo --logger "console;verbosity=detailed" .\$solutionName\$testProjectName\$testProjectCsproj
"@


$workflowScript | Out-File -FilePath $solutionNameYml

# --------------------
# BACK TO ROOT FOLDER
# -------------------

cd ..
cd ..