namespace RunningSum;

public class Program
{
    public static int[] Sum(int[] nums) 
    {
        int[] results = new int[nums.Length];
        results[0] = nums[0];

        for (int i = 1 ; i < nums.Length ; i++)
        {
            results[i] = nums[i] + results[i-1]; 
        }
        return results;
    }

    public static void Main(){}
}
