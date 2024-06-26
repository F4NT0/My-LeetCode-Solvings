using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearch;

namespace WordSearchTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[]  { 'S', 'F', 'C', 'S' },
            new char[]  {'A','D', 'E', 'E' }
        };
        string word = "ABCCED"; 
        
        // Act
        bool result = Program.Exist(board, word);

        // Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[]  { 'S', 'F', 'C', 'S' },
            new char[]  {'A','D', 'E', 'E' }
        };
        string word = "SEE"; 
        
        // Act
        bool result = Program.Exist(board, word);

        // Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[]  { 'S', 'F', 'C', 'S' },
            new char[]  {'A','D', 'E', 'E' }
        };
        string word = "ABCB"; 
        
        // Act
        bool result = Program.Exist(board, word);

        // Assert
        Assert.AreEqual(false, result);
    }
}
