using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiddleLinkedList;

namespace MiddleLinkedListTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode expected = new ListNode(3, new ListNode(4, new ListNode(5)));
        
        // Act
        ListNode result = Program.MiddleNode(head);

        // Assert
        Assert.IsTrue(Program.AreEqual(expected, result));
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
        ListNode expected = new ListNode(4, new ListNode(5, new ListNode(6)));
        
        // Act
        ListNode result = Program.MiddleNode(head);

        // Assert
        Assert.IsTrue(Program.AreEqual(expected, result));
    }
}
