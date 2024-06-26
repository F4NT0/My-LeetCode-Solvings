namespace ValidAnagram
{
    public class Program
    {
      public static bool IsAnagram(string s, string t) 
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var sChar = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            var tChar = t.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            return sChar.Keys.All(k => tChar.ContainsKey(k) && sChar[k] == tChar[k]);
        }

        public static void Main(){}
    }
}
