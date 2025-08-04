// Binary tree
Console.WriteLine("Binary Tree");
Console.WriteLine("With Selection Sort and Binary Search");
Console.WriteLine("===========");

int[] arr = [5, 3, 8, 1, 4, 7, 9, 2, 6];
Console.WriteLine("Unsorted array:");
WriteArray(arr);

int[] sortedArray = SelectionSort(arr);
Console.WriteLine("Sorted array:");
WriteArray(sortedArray);

BinarySearch(sortedArray, 9);

// Time complexity: O(log n)
// Space complexity: O(1)
// Binary search algorithm implementation
static int BinarySearch(int[] sortedArray, int target)
{
    int left = 0;
    int right = sortedArray.Length - 1;

    while (left <= right)
    {
        // finding the middle index
        Console.WriteLine($"Left: {left}, Right: {right}");
        int midlle = (left + right) / 2; // First sum then divide

        if (sortedArray[midlle] == target)
        {
            Console.WriteLine($"Found {target} at index {midlle}");
            return midlle;
        }
        else if (sortedArray[midlle] < target)
        {
            left = midlle + 1;
        }
        else
        {
            right = midlle - 1;
        }
    }

    return -1; // Not found
}

static int[] SelectionSort(int[] arr)
{
    int[] sortedArray = new int[arr.Length]; // Array to hold the sorted elements
    int[] copiedArray = arr.ToArray(); // Create a copy of the original array in case we need to keep it unchanged

    for (int i = 0; i < arr.Length; i++)
    {
        int smallestIndex = FindSmallest(copiedArray); // Find the index of the smallest element
        sortedArray[i] = arr[smallestIndex]; // Place the smallest element in the sorted array
        copiedArray[smallestIndex] = int.MaxValue; // Mark as used set it to a large value
    }

    return sortedArray;
}

static int FindSmallest(int[] arr)
{
    int smallestIndex = 0;
    int smallestNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < smallestNumber)
        {
            smallestNumber = arr[i];
            smallestIndex = i;
        }
    }

    return smallestIndex;
}

static void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
}

