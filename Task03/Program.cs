const int SIZE = 10;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 999;
const int THE_NUMBER = 4;

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

void FindNumber(int[] arr, int number)
{
    string answer = "В массиве нет этого числа: ";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number || arr[i] == -number)
        {
            answer = "В массиве есть это число: ";
        }
    }
    System.Console.WriteLine(answer + number);
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
FindNumber(array, THE_NUMBER);