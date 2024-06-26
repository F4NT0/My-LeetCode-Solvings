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
        int[][] accounts = new int[][]
        {
            new int[] {1,2,3},
            new int[] {3,2,1}
        };
        
        // Act
        int result = Program.MaximumWealth(accounts);

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        int[][] accounts = new int[][]
        {
            new int[]{1,5},
            new int[]{7,3},
            new int[]{3,5}
        };
        
        // Act
        int result = Program.MaximumWealth(accounts);

        // Assert
        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        int[][] accounts = new int[][]
        {
            new int[]{2,8,7},
            new int[]{7,1,3},
            new int[]{1,9,5}
        };
        
        // Act
        int result = Program.MaximumWealth(accounts);

        // Assert
        Assert.AreEqual(17, result);
    }
}
