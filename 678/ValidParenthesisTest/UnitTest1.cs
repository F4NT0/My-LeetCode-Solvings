using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidParenthesis;

namespace ValidParenthesisTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string value = "()";
        bool expected = true;
        
        // Act
        bool result = Program.CheckValidString(value);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string value = "(*)";
        bool expected = true;
        
        // Act
        bool result = Program.CheckValidString(value);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        string value = "(*))";
        bool expected = true;
        
        // Act
        bool result = Program.CheckValidString(value);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
