using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeStrings;

namespace MergeStringsTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string word1 = "abc";
        string word2 = "pqr";
        string expected = "apbqcr";
        
        // Act
        string result = Program.MergeAlternately(word1, word2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string word1 = "ab";
        string word2 = "pqrs";
        string expected = "apbqrs";
        
        // Act
        string result = Program.MergeAlternately(word1, word2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example3()
    {
        // Arrange
        string word1 = "abcd";
        string word2 = "pq";
        string expected = "apbqcd";
        
        // Act
        string result = Program.MergeAlternately(word1, word2);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
