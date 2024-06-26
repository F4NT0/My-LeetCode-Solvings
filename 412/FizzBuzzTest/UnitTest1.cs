using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        int n = 3;
        IList<string> expected = new List<string> { "1", "2", "Fizz" };
        
        // Act
        IList<string> result = Program.FizzBuzz(n);

        // Assert
        CollectionAssert.AreEqual(expected.ToList(), result.ToList());
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        int n = 5;
        IList<string> expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };
        
        // Act
        IList<string> result = Program.FizzBuzz(n);

        // Assert
        CollectionAssert.AreEqual(expected.ToList(), result.ToList());
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        int n = 15;
        IList<string> expected = new List<string> {"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"};
        
        // Act
        IList<string> result = Program.FizzBuzz(n);

        // Assert
        CollectionAssert.AreEqual(expected.ToList(), result.ToList());
    }
}
