namespace Problems.Medium
{
    public class NumsIslands
    {
        public static int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int lands = 0;

            void DFS(int i, int j)
            {
                if (i < 0 || i == m || j < 0 || j == n || grid[i][j] == '0') { return; }

                grid[i][j] = '0';

                DFS(i + 1, j);
                DFS(i - 1, j);
                DFS(i, j + 1);
                DFS(i, j - 1);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(i, j);
                        lands += 1;
                    }
                }
            }
            return lands;
        }
    }
}
