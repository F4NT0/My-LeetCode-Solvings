using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;

namespace TwoSumTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        
        // Act
        int[] result = Program.TwoSum(nums, target);

        // Assert
        CollectionAssert.AreEqual(new int[]{0,1}, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        int[] nums = new int[] { 3, 2, 4};
        int target = 6;
        
        // Act
        int[] result = Program.TwoSum(nums, target);

        // Assert
        CollectionAssert.AreEqual(new int[]{1,2}, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        int[] nums = new int[] { 3, 3};
        int target = 6;
        
        // Act
        int[] result = Program.TwoSum(nums, target);

        // Assert
        CollectionAssert.AreEqual(new int[]{0,1}, result);
    }
}
