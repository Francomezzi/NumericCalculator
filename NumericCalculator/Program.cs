// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number1;
int number2;
int result;

Console.WriteLine("Select the operation you want to do:\nSuma\nResta\nMultiplicacion\nDivision");
string select = Console.ReadLine();

switch (select)
{
    case "Suma":
        Console.WriteLine("Input the first number");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number");
        number2 = Convert.ToInt32(Console.ReadLine());

        result = number1 + number2;
        Console.WriteLine("The result is: " + result);
        break;
    case "Resta":
        Console.WriteLine("Input the first number");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number");
        number2 = Convert.ToInt32(Console.ReadLine());

        result = number1 - number2;
        Console.WriteLine("The result is: " + result);
        break;
    case "Multiplicacion":
        Console.WriteLine("Input the first number");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number");
        number2 = Convert.ToInt32(Console.ReadLine());

        result = number1 * number2;
        Console.WriteLine("The result is: " + result);
        break;
    case "Division":
        Console.WriteLine("Input the first number");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number");
        number2 = Convert.ToInt32(Console.ReadLine());

        result = number1 / number2;
        Console.WriteLine("The result is: " + result);
        break;
}

