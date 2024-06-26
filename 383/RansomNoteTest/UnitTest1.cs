using Microsoft.VisualStudio.TestTools.UnitTesting;
using RansomNote;

namespace RansomNoteTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string ransomNote = "a";
        string magazine = "b";
        
        // Act
        bool result = Program.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string ransomNote = "aa";
        string magazine = "ab";
        
        // Act
        bool result = Program.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        string ransomNote = "aa";
        string magazine = "aab";
        
        // Act
        bool result = Program.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Example4()
    {
        // Arrange
        string ransomNote = "aab";
        string magazine = "baa";
        
        // Act
        bool result = Program.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.AreEqual(true, result);
    }
}
