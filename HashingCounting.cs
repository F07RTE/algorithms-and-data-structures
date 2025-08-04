// Find a sum of all sub array that have a sum exactly equal to k
// int[] array = [6, 5, -3, 2, -4, 8, 10];
int[] array = [1, 1, 2, 1, 1];
// int[] array = [1, 2, 1, 2, 1];
int k = 3;

int answer = PrefixOddCount(array, k);

Console.WriteLine("Answer: " + answer);

static int FindSubArray(int[] array, int k)
{
    Console.WriteLine("Working...");

    // HashMap to find how offen a prefixSum happens
    Dictionary<int, int> counts = new Dictionary<int, int>();
    counts[0] = 1;
    int answer = 0;
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        current += array[i];

        int check = current - k;

        if (counts.ContainsKey(check))
        {
            answer++;
        }

        if (counts.ContainsKey(current))
        {
            counts[current] += 1;
        }
        else
        {
            counts.Add(current, 1);
        }
    }

    LogDictonary(counts);

    return answer;
}

static int PrefixOddCount(int[] array, int k)
{
    Console.WriteLine("Prefix Odd Count");

    Dictionary<int, int> counts = new Dictionary<int, int>();
    counts[0] = 1;
    int answer = 0;
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        current += array[i] % 2;

        int check = current - k;

        if (counts.ContainsKey(check))
        {
            answer++;
        }

        if (counts.ContainsKey(current))
        {
            counts[current] += 1;
        }
        else
        {
            counts.Add(current, 1);
        }
    }

    LogDictonary(counts);

    return answer;

}

static void LogArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

static void LogDictonary(Dictionary<int, int> dictionary)
{
    foreach (KeyValuePair<int, int> pair in dictionary)
    {
        Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
    }
}