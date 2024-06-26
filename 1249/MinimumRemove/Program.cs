using System.Text;
namespace MinimumRemove
{
    public class Program
    {
      public static string MinRemoveToMakeValid(string s) 
        {
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < s.Length; ++i)
            {
                if (sb[i] == '(') 
                {
                    stack.Push(i);
                } 
                else if (sb[i] == ')') 
                {
                    if (stack.Count == 0)
                    {
                        sb[i] = '#';
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            while (stack.Count != 0)
            {
                sb[stack.Pop()] = '#';
            }

            return sb.ToString().Replace("#", "");
        }

        public static void Main(){}
    }
}
