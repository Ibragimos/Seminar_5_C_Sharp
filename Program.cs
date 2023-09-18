Random random = new Random();

int RandSize()
    {
        int s = random.Next(5, 10);
        return s;
    }

void RandElements(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(99, 1000);
        }
    }



int[] arr = new int[RandSize()];
RandElements(arr);
