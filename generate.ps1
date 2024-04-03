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

Write-Host  'Adding Template code into the project...' -ForegroundColor DarkYellow
Write-Host ''
$code = @"
namespace $projectName
{
    public class Program
    {
        static void Main(string[] args)
        {
            string test = GetHelloWorld();
            Console.WriteLine(test);
        }

        public static string GetHelloWorld()
        {
            return `"Hello World!`";
        }
    }
}
"@

$code | Out-File -FilePath $projectName/Program.cs

# --------------------------------
# ADD TESTS INTO THE TEST PROJECT
# --------------------------------

Write-Host  'Adding Template code into the project test...' -ForegroundColor DarkYellow
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
Write-Host  'Running the tests...' -ForegroundColor Magenta
Write-Host ''
$testProjectCsproj = $testProjectName + '.csproj'
dotnet test $testProjectName/$testProjectCsproj