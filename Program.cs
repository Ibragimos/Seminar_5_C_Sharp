Random random = new Random();

    int RandSize()
    {
        int s = random.Next(10, 20);
        return s;
    }

 void RandElements(int[] arr)
    {
        for (double i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100);
        }
    }

    double[] arr = new double[RandSize()];
