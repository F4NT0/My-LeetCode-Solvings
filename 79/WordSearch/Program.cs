namespace WordSearch
{
    public class Program
    {
      public static bool Exist(char[][] board, string word) 
        {
            for (int m = 0 ; m < board.Length; m++) // Acess the line
            {
                for (int n = 0 ; n < board[0].Length ; n++) // Acess the column
                {
                    if (search(board,word,m,n,0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool search(char[][] board, string word, int m, int n, int s)
        {
            if (m < 0 || m == board.Length || n < 0 || n == board[0].Length) // avoid outside the matrix
            {
                return false;
            }

            if (board[m][n] != word[s] || board[m][n] == '*') // avoid letters outside the word
            {
                return false;
            }

            if (s == word.Length - 1)
            {
                return true;
            }

            char cache = board[m][n]; // keep the value before verifying
            board[m][n] = '*'; // value to search
            bool isExists = search(board,word,m+1,n,s+1) || search(board,word,m-1,n,s+1) || search(board,word,m,n+1,s+1) || search(board,word,m,n-1,s+1);
            board[m][n] = cache; // get back the value
            return isExists;
        }

        public static void Main(){}
    }
}
