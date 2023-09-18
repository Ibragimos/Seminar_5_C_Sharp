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
           System.Console.Write($" {arr[i]} ");
           if(arr[i] < min)
           {
            min = arr[i];
           }
        }
        /*System.Console.WriteLine();
        double max = arr.Max();
        System.Console.WriteLine(max);
        double min = arr.Min();
        System.Console.WriteLine(min);*/
    return min;
    }

    double Max(double[] arr)
    {
        double max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
           System.Console.Write($" {arr[i]} ");
           if(max < arr[i])
           {
            max = arr[i];
           }
        }
        return max;
    }


    double[] arr = new double[RandSize()];
    RandElements(arr);
    Min(arr);
    Max(arr);
    Thread.Sleep(10000);
    Console.Clear(); 
