namespace IsomorphicStrings
{
    public class Program
    {
        public static bool IsIsomorphic(string s, string t) 
        {
            Dictionary<char, char> sToT = new Dictionary<char, char>();
            Dictionary<char, char> tToS = new Dictionary<char, char>();

            if (s.Length == t.Length)
            {
                for (int i = 0; i < s.Length; i++)
                {   
                    char charS = s[i];
                    char charT = t[i];

                    if (sToT.ContainsKey(charS))
                    {
                        if (sToT[charS] != charT)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        sToT[charS] = charT;
                    }

                    if (tToS.ContainsKey(charT))
                    {
                        if (tToS[charT] != charS)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        tToS[charT] = charS;
                    }
                }
                return true;
            }
            return false;
        }
        public static void Main(){}
    }
}
