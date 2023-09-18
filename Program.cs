
Random random = new Random();

    int RandSize()
    {
        int s = random.Next(10, 20);
        return s;
    }

 void RandElements(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(99, 1000);
        }
    }

void Even_Numbers(int[] arr)
{
    System.Console.Write("Even numbers: ");
    for (int i = 0; i < arr.Length; i++)
    {
        
        if(arr[i] % 2 == 0)
        {
            System.Console.Write($" {arr[i]}");
        }
    }
    
}


int[] arr = new int[RandSize()];
RandElements(arr);
Even_Numbers(arr);