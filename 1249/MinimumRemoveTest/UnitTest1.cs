using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinimumRemove;

namespace MinimumRemoveTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string s = "lee(t(c)o)de)";
        string expected = "lee(t(c)o)de";
        
        // Act
        string result = Program.MinRemoveToMakeValid(s);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string s = "a)b(c)d";
        string expected = "ab(c)d";
        
        // Act
        string result = Program.MinRemoveToMakeValid(s);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        string s = "))((";
        string expected = "";
        
        // Act
        string result = Program.MinRemoveToMakeValid(s);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
