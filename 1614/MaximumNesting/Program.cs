namespace MaximumNesting
{
    public class Program
    {
      public static int MaxDepth(string s) 
        {
            int ans = 0;
            int opened = 0;

            foreach (char c in  s.ToCharArray())
            {
                if (c == '(')
                {
                    ans = Math.Max(ans, ++opened); // change before opened
                }
                else if (c == ')')
                {
                    --opened; // change before opened
                }
            }   

            return ans;
        }

        public static void Main(){}
    }
}
