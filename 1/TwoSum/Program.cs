namespace TwoSum
{
    public class Program
    {
      public static int[] TwoSum(int[] nums, int target) 
        {
            Dictionary<int,int> m = new Dictionary<int, int>();
            
            for (int i = 0, j; ; ++i) 
            {
                int x = nums[i];
                int y = target - x;
                
                if (m.TryGetValue(y, out j)) {
                    return new int[] {j, i};
                }
                if (!m.ContainsKey(x)) {
                    m.Add(x, i);
                }
            }
        }

      public static void Main(){}
    }
}
