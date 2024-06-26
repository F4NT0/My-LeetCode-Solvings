using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReduceToZero;

namespace ReduceToZeroTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        int num = 14;
        
        // Act
        int result = Program.NumberOfSteps(num);

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        int num = 8;
        
        // Act
        int result = Program.NumberOfSteps(num);

        // Assert
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        int num = 123;
        
        // Act
        int result = Program.NumberOfSteps(num);

        // Assert
        Assert.AreEqual(12, result);
    }
}
