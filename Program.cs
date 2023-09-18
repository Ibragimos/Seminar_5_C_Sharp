int RandSize()
{
    Random size = new Random();
    int s = size.Next(5, 20);
    return s;
}

void RandElements(int[] arr)
{
    Random random = new Random();
    
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(99, 1000);
}

}


int[] arr = new int[RandSize()];
RandElements(arr);