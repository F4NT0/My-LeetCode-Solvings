namespace Project
{
    public class Program
    {
        public static int LengthOfLastWord(string s) 
        {
            s = s.TrimEnd();
            string[] words = s.Split(' ');
            return words[words.Length-1].Length;
        }
        public static void Main(){}
    }
}
