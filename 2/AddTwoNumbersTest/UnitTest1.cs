using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddTwoNumbers;

namespace AddTwoNumbersTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        ListNode expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        
        // Act
        ListNode result = Program.AddTwoNumbers(l1, l2);

        // Assert
        Assert.IsTrue(Program.AreEqual(expected, result));
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        ListNode l1 = new ListNode(0);
        ListNode l2 = new ListNode(0);
        ListNode expected = new ListNode(0);
        
        // Act
        ListNode result = Program.AddTwoNumbers(l1, l2);

        // Assert
        Assert.IsTrue(Program.AreEqual(expected, result));
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        ListNode expected = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));
        
        // Act
        ListNode result = Program.AddTwoNumbers(l1, l2);

        // Assert
        Assert.IsTrue(Program.AreEqual(expected, result));
    }
}
