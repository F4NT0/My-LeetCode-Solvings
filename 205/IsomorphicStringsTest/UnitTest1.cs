using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsomorphicStrings;

namespace IsomorphicStringsTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string s = "egg";
        string t = "add";
        
        // Act
        bool result = Program.IsIsomorphic(s, t);

        // Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string s = "foo";
        string t = "bar";
        
        // Act
        bool result = Program.IsIsomorphic(s, t);

        // Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        string s = "paper";
        string t = "title";
        
        // Act
        bool result = Program.IsIsomorphic(s, t);

        // Assert
        Assert.AreEqual(true, result);
    }
}
