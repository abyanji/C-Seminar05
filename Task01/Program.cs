const int SIZE = 12;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

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

void SumPositiveAndNegative(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for(int i = 0 ; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
        sumP += arr[i];
        }
        else
        {
        sumN += arr[i];
        }
    }

}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
SumPositiveAndNegative(array, out int sumP, out int sumN);

System.Console.WriteLine($"Сумма положительных элементов массива = {sumP}");
System.Console.WriteLine($"Сумма отрицательных элементов массива = {sumN}");