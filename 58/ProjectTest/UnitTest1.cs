using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;

namespace ProjectTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string entry = "Hello World";
        
        // Act
        int result = Program.LengthOfLastWord(entry);

        // Assert
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string entry = "   fly me   to   the moon  ";
        
        // Act
        int result = Program.LengthOfLastWord(entry);

        // Assert
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        string entry = "luffy is still joyboy";
        
        // Act
        int result = Program.LengthOfLastWord(entry);

        // Assert
        Assert.AreEqual(6, result);
    }
}
