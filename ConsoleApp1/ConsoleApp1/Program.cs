// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double GetAvg(int[] arr)
{
    double res = 0.0;
    for (int i  = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }

    return res / arr.Length;
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
double average = GetAvg(arr);
Console.WriteLine(average);

