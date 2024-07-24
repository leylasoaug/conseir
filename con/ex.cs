/// Proposal with the corresponding dimension of the specified size.
/// Creates a 2D array with the given number of rows and columns, initialized to the specified value.
public static int[,] CreateMatrix(int rows, int cols, int value)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = value;
        }
    }
    return matrix;
}

static void Main(string[] args)
{
    int[,] matrix = CreateMatrix(3, 4, 7);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
