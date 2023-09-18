int Rand()
{
    Random size = new Random();
    int s = size.Next(5, 20);
    return s;
}




int[] arr = new int[Rand()];