const int SIZE = 4;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

int[] array = new int[SIZE];

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

void ChangeArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
ChangeArr(array);