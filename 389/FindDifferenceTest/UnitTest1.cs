using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindDifference;

namespace FindDifferenceTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string s = "abcd";
        string t = "abcde";
        char expected = 'e';
        
        // Act
        char result = Program.FindTheDifference(s, t);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string s = "";
        string t = "y";
        char expected = 'y';
        
        // Act
        char result = Program.FindTheDifference(s, t);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
