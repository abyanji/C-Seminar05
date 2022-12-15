const int SIZE = 5;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[] array = new int[SIZE];
int[] array2 = new int[SIZE / 2 + SIZE % 2];

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0 ; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] NewArray(int[] arr, int[] arr2)
{
    for(int i = 0 ; i < arr.Length / 2; i++)
    {
        arr2[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return arr2;
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
array2 = NewArray(array, array2);
if (SIZE % 2 != 0)
{
    array2[array2.Length - 1] = array[array.Length / 2 + 1];
}
Console.WriteLine($"[{string.Join(", ", array2)}]");