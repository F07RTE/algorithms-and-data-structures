// Fibonacci
// Formula => n = (n - 1) + (n - 2)

Console.WriteLine("Type the number:");
int number = int.Parse(Console.ReadLine());

int result = Fibonacci(number);
Console.WriteLine("result: " + result);

static int Fibonacci(int num)
{
    if (num == 0 || num == 1)
    {
        return num;
    }

    int current = 1;
    int num1 = 1;
    int num2 = 1;

    for (int i = 2; i < num; i++)
    {
        // i = 8 && num = 9
        // current = 21 + 13 = 34
        current = num1 + num2;
        // 13
        num2 = num1; // oldest fibonacci number
        // num1 = 21
        num1 = current; // newest fibonacci number

    }

    return current;
}
