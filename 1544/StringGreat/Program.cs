using System.Text;
namespace StringGreat
{
    public class Program
    {
      public static string MakeGood(string s) 
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s.ToCharArray())
            {
                if (sb.Length > 0 && Bad(sb[sb.Length - 1], c))
                {
                    sb.Remove(sb.Length-1,1);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static bool Bad(char a, char b)
        {
            if (a != b && Char.ToLower(a) == Char.ToLower(b))
            {
                return true;
            }
            return false;
        }

        public static void Main(){}
    }
}
