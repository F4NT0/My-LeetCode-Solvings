using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindIndex;

namespace FindIndexTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Example1()
    {
        // Arrange
        string needle = "sad";
        string haystack = "sadbutsad";
        int expected = 0;
        
        // Act
        int result = Program.StrStr(haystack, needle);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Example2()
    {
        // Arrange
        string needle = "leeto";
        string haystack = "leetcode";
        int expected = -1;
        
        // Act
        int result = Program.StrStr(haystack, needle);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
