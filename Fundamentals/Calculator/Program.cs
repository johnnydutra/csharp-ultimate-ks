Console.WriteLine("Hello");

Console.WriteLine("Input the first number:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userInput = Console.ReadLine();

if (userInput == "a" || userInput == "A")
{
    int result = AddNumbers(firstNumber, secondNumber);
    PrintCalculation(firstNumber, secondNumber, result, "+");
}
else if (userInput == "s" || userInput == "S")
{
    int result = SubtractNumbers(firstNumber, secondNumber);
    PrintCalculation(firstNumber, secondNumber, result, "-");
}
else if (userInput == "m" || userInput == "M")
{
    int result = MultiplyNumbers(firstNumber, secondNumber);
    PrintCalculation(firstNumber, secondNumber, result, "*");
}
else
{
    Console.WriteLine("Invalid input");
}

int AddNumbers(int a, int b)
{
    return a + b;
}

int SubtractNumbers(int a, int b)
{
    return a - b;
}

int MultiplyNumbers(int a, int b)
{
    return a * b;
}

void PrintCalculation(int a, int b, int result, string @operator)
{
    Console.WriteLine(a + " " + @operator + " " + b + " = " + result);
}

Console.ReadKey();