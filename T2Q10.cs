using System;

public class T2Q10
{
    public int matSearch(int[,] mat, int N, int M, int X)
    {
        int i = 0, j = M - 1; // start from top-right corner

        while (i < N && j >= 0)
        {
            if (mat[i, j] == X)
                return 1; // found
            else if (mat[i, j] > X)
                j--; // move left
            else
                i++; // move down
        }

        return 0; // not found
    }
    static void Main(string[] args)
    {
        T2Q10 sol = new T2Q10();

        // Example 1
        int[,] mat1 = { { 3, 30, 38 }, { 44, 52, 54 }, { 57, 60, 69 } };
        int N1 = 3, M1 = 3, X1 = 62;
        int res1 = sol.matSearch(mat1, N1, M1, X1);
        Console.WriteLine(res1); // Output: 0

        // Example 2
        int[,] mat2 = { { 18, 21, 27, 38, 55, 67 } };
        int N2 = 1, M2 = 6, X2 = 55;
        int res2 = sol.matSearch(mat2, N2, M2, X2);
        Console.WriteLine(res2); // Output: 1

        Console.ReadLine();
    }
}
