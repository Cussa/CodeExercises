using System;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class MinimumPathSum
    {
        public int Resolve(int[][] grid)
        {
            for (var r = 0; r < grid.Length; r++)
            {
                for (var c = 0; c < grid[r].Length; c++)
                {
                    if (c == 0 && r == 0)
                        continue;

                    if (r - 1 < 0)
                        grid[r][c] = grid[r][c] + grid[r][c - 1];
                    else if (c - 1 < 0)
                        grid[r][c] = grid[r][c] + grid[r - 1][c];
                    else
                        grid[r][c] = grid[r][c] + Math.Min(grid[r][c - 1], grid[r - 1][c]);
                }
            }

            return grid[^1][grid[0].Length - 1];
        }
    }
}
