Random random = new Random();

    int RandSize()
    {
        int s = random.Next(10, 20);
        return s;
    }

 void RandElements(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Math.Round(1.0 + random.NextDouble() * 49.0, 2);
        }
    }

    double Min(double[] arr)
    {
        double min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
           if(arr[i] < min)
           {
            min = arr[i];
           }
        }
        System.Console.WriteLine($" min = {min}");
        return min;
    }

    double Max(double[] arr)
    {
        double max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
           if(max < arr[i])
           {
            max = arr[i];
           }
        }
        System.Console.WriteLine($" max = {max}");
        return max;
    }

double Diff(double[] arr)
{
    double max = Max(arr);
    double min = Min(arr);
    double diff = max - min;
    System.Console.WriteLine($" max - min = {diff}");
    return diff;
}

    double[] arr = new double[RandSize()];
    RandElements(arr);
    string s = string.Join(" ", arr);
    System.Console.Write($"{s}\n");
    Diff(arr);
    Thread.Sleep(4000);
    Console.Clear(); 
     /*System.Console.WriteLine();
        double max = arr.Max();
        System.Console.WriteLine(max);
        double min = arr.Min();
        System.Console.WriteLine(min);*/
