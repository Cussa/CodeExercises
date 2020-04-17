namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class NumberOfIslands
    {
        private const char Zero = '0';

        public int Resolve(char[][] grid)
        {
            var numberOfIslands = 0;

            for (var r = 0; r < grid.Length; r++)
            {
                for (var c = 0; c < grid[r].Length; c++)
                {
                    if (grid[r][c] == Zero)
                        continue;

                    Search(grid, r, c);
                    numberOfIslands++;
                }
            }

            return numberOfIslands;
        }

        private void Search(char[][] grid, int r, int c)
        {
            if (grid[r][c] == Zero)
                return;

            grid[r][c] = Zero;

            if (r + 1 < grid.Length)
                Search(grid, r + 1, c);

            if (r - 1 >= 0)
                Search(grid, r - 1, c);

            if (c + 1 < grid[0].Length)
                Search(grid, r, c + 1);

            if (c - 1 >= 0)
                Search(grid, r, c - 1);
        }
    }
}
