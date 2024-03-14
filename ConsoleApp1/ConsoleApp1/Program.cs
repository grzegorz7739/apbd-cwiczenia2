// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double GetAverage(int[] arr)
{
    double result = 0.0;
    for (int i  = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }

    return result / arr.Length;
}

static int GetMaxVal(int[] arr)
{
    int res = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        int temp = arr[i];
        if (temp > res)
        {
            res = temp;
        }
    }
    return res;
}

int[] arr = {1,2,3,4};
double average = GetAverage(arr);
Console.WriteLine(average);

Console.WriteLine(GetMaxVal(arr));