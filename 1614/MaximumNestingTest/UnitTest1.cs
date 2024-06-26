using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNesting;

namespace MaximumNestingTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string s = "(1+(2*3)+((8)/4))+1";
        
        // Act
        int result = Program.MaxDepth(s);

        // Assert
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string s = "(1)+((2))+(((3)))";
        
        // Act
        int result = Program.MaxDepth(s);

        // Assert
        Assert.AreEqual(3, result);
    }
}
