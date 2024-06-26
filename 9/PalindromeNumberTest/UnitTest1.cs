using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeNumber;

namespace PalindromeNumberTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        int x = 121;
        
        // Act
        bool result = Program.IsPalindrome(x);

        // Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        int x = -121;
        
        // Act
        bool result = Program.IsPalindrome(x);

        // Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        int x = 10;
        
        // Act
        bool result = Program.IsPalindrome(x);

        // Assert
        Assert.AreEqual(false, result);
    }
}
