// See https://aka.ms/new-console-template for more information
int[] items = new int[] { 1, 12, 5, 111, 200 };

int sum = 10;

Console.WriteLine(MaxItemsForSum(items, sum));

static int MaxItemsForSum(int[] items, int intsum)
{
    int maxItems = 0;

    PriorityQueue<int,int> queue = new PriorityQueue<int, int>();
    
    for(int i = 0; i < items.Length; i++)
    {
        queue.Enqueue(items[i],i);

    }
    


    return maxItems;
}