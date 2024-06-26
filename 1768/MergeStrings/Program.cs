using System.Text;
namespace MergeStrings
{
    public class Program
    {
      public static string MergeAlternately(string word1, string word2) 
      {
            int size = Math.Min(word1.Length, word2.Length);
            StringBuilder sb = new StringBuilder();

            for (int i = 0 ; i < size ; i++)
            {
                sb.Append(word1[i]);
                sb.Append(word2[i]);
            }
            sb.Append(word1.Substring(size));
            sb.Append(word2.Substring(size));
            return sb.ToString();
        }

      public static void Main(){}
    }
}
