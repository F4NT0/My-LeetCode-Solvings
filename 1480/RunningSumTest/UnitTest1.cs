using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunningSum;

namespace RunningSumTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        int[] nums = {1, 2, 3, 4};
        
        // Act
        int[] result = Program.Sum(nums);

        // Assert
        CollectionAssert.AreEqual(new int[]{1,3,6,10}, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        int[] nums = {1, 1, 1, 1, 1};
        
        // Act
        int[] result = Program.Sum(nums);

        // Assert
        CollectionAssert.AreEqual(new int[]{1,2,3,4, 5}, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        int[] nums = {3, 1, 2, 10, 1};
        
        // Act
        int[] result = Program.Sum(nums);

        // Assert
        CollectionAssert.AreEqual(new int[]{3, 4, 6, 16, 17}, result);
    }
}
