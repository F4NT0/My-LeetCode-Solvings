namespace FindDifference
{
    public class Program
    {
      public static char FindTheDifference(string s, string t) 
        {
            // XOR operations
            int sXors = s.Aggregate(0,(a,b) => a ^ b);
            int tXors = t.Aggregate(0,(a,b) => a ^ b);
            return (char) (sXors ^ tXors); // bitwise operation for XOR (binary)
        }

      public static void Main(string[] args){}
    }
}

