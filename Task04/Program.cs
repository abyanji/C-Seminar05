const int SIZE = 123;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 1000;

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

int AmountOfNumbers(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            num++;
        }
    }
    return num;
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
int amount = AmountOfNumbers(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> {amount}");