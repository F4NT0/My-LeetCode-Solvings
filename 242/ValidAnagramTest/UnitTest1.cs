using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidAnagram;

namespace ValidAnagramTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string s = "anagram";
        string t = "nagaram";
        bool expected = true;
        
        // Act
        bool result = Program.IsAnagram(s, t);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string s = "rat";
        string t = "car";
        bool expected = false;
        
        // Act
        bool result = Program.IsAnagram(s, t);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
