// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double GetAvg(int[] arr)
{
    double result = 0.0;
    for (int i  = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }

    return result / arr.Length;
}

int[] arr = {1,2,3,4};
double average = GetAvg(arr);
Console.WriteLine(average);