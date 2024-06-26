using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringGreat;

namespace StringGreatTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string s  = "leEeetcode";
        string expected = "leetcode";
        
        // Act
        string result = Program.MakeGood(s);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string s  = "abBAcC";
        string expected = "";
        
        // Act
        string result = Program.MakeGood(s);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        string s  = "s";
        string expected = "s";
        
        // Act
        string result = Program.MakeGood(s);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
