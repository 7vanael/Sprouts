namespace Roomba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cleaning a grid of N x M,
            //represented by array R consisting of N strings, which are M-1 long
            //Robot starts in top left corner, facing right. Moves forward, turns right if blocked.
            // '.' = an empty square
            // 'X' = Occupied, or blocked square
            string[] room = {"....X..X", "X....X..", "...X.X.." };
            var vacuum = new Solution();
            var unitsCleaned = vacuum.solution(room);

            
        }
    }
}