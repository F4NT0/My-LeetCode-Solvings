namespace RansomNote
{
    public class Program
    {
        public static bool CanConstruct(string ransomNote, string magazine) 
        {
            List<char> letters = new List<char>(magazine);
            int counter = 0;
            foreach(char l in ransomNote)
            {
                if(letters.Contains(l))
                {
                    letters.Remove(l);
                    counter++;
                }
            }
            if (counter == ransomNote.Length)
            {
                return true;
            }
            return false;
        }
        public static void Main(){}
    }
}
