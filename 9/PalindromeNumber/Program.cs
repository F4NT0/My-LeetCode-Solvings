namespace PalindromeNumber
{
    public class Program
    {
      
      public static bool IsPalindrome(int x) 
        {
            char[] entry = x.ToString().ToCharArray();
            Array.Reverse(entry);
            if (x.ToString().Equals(new string(entry)))
            {
                return true;
            }
            return false;
        }

      public static void Main(){}
    }
}
