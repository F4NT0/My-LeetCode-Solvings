namespace ValidParenthesis
{
    public class Program
    {
      public static bool CheckValidString(string s) 
    {
        int low = 0;  // the lower bound of the number of valid '('s
        int high = 0; // the upper bound of the number of valid '('s

        foreach (char c in s.ToCharArray()) 
        {
            switch (c) 
            {
                case '(':
                    ++low;
                    ++high;
                break;
                case ')':
                    low = Math.Max(0, --low);
                    --high;
                break;
                case '*':
                    low = Math.Max(0, --low);
                    ++high;
                break;
            }
            if (high < 0)
            {
                return false;
            }
        }

        return low == 0;
    }

      public static void Main(){}
    }
}
