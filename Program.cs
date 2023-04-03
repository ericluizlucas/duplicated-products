class Solver
{
    static int Solve(string[] names, int[] price, int[] weight, int lenght)
    {
        List<int> doneIndexes = new List<int>();
        int duplicatedQuantity = 0;
        for (int i = 0; i < lenght; i++)
        {
            for (int j = i + 1; j < lenght; j++)
            {
                if (names[i] == names[j] && price[i] == price[j] && weight[i] == weight[j])
                {
                    bool indexExists = false;
                    foreach (var index in doneIndexes)
                    {
                        if (index == j) indexExists = true;
                    }
                    if (!indexExists)
                    {
                        duplicatedQuantity += 1;
                        doneIndexes.Add(j);
                    }
                }
            }
        }

        return duplicatedQuantity;
    }

    public static void Main()
    {
        string[] inputNames = new string[] { "ball", "box", "ball", "ball", "box" };
        int[] inputPrice = new int[] { 2, 2, 2, 2, 2 };
        int[] inputWeight = new int[] { 1, 2, 1, 1, 3 };
        int resp = Solve(inputNames, inputPrice, inputWeight, inputNames.Length);

        Console.WriteLine(resp);
    }

}
