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
            arr[i] = random.Next(-30, 30);
        }
    }

void SumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 != 0)
        {
            System.Console.Write($" {arr[i]}");
            sum += arr[i];

        }
    }
    System.Console.WriteLine($" Sum Odd Elements = {sum}");
}

int[] arr = new int[RandSize()];
RandElements(arr);
SumOddElements(arr);

Thread.Sleep(5000);
Console.Clear(); 