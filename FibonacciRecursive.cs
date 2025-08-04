
int number = 9;
int result = Fibonacci(number);

Console.WriteLine(result);

static int Fibonacci(int num)  // 6
{
    if (num <= 1)
    {
        return num;
    }

    int first = Fibonacci(num - 1); // 0, 1, 2, 3, 5
    int second = Fibonacci(num - 2); // 0, 1, 2, 3

    return first + second; // 8
}