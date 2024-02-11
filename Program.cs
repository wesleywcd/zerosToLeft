ZerosToLeft(new[] { 1, 10, 20, 0, 59, 0, 88, 0 });
ZerosToLeft(new[] { 7, 4, 0, 10, 43, 2, 5, 0, 20 });

static void ZerosToLeft(int[] array)
{
    int n = array.Length;
    int writeIndex = n - 1;

    for (int i = n - 1; i >= 0; i--)
    {
        if (array[i] != 0)
        {
            int temp = array[writeIndex];
            array[writeIndex] = array[i];
            array[i] = temp;

            writeIndex--;
        }
    }

    Console.WriteLine(string.Join(",", array));
}