//CalculatR
// 09.03.2023


internal class Program
{
    private static void Main(string[] args)
    {
        string password = "";

        do
        {
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
        } while (password != "qwerty");

        Console.Write("\nEnter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /, %): ");
        char operation = Convert.ToChar(Console.ReadLine()[0]);

        Console.Write("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        //ternary
        string message = 
            !(firstNumber >= 0) 
            ? "\n1st number is not positive!" 
            : "\n1st number is positive!";
        System.Console.WriteLine(message);

        if (firstNumber > secondNumber)
        {
            System.Console.WriteLine("\n1st number is greter than 2nd number.");
        }
        else if (firstNumber == secondNumber)
        {
            System.Console.WriteLine("\n1st number is equal to 2nd number.");
        }
        else
        {
            System.Console.WriteLine("\n1st number is less than 2nd number.");
        }

        string result = operation switch
        {
            '+' => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
            '-' => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
            '*' => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
            '/' => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
            '%' => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
            _ => "Operation not found!"
        };
        System.Console.WriteLine($"\n{result}\n");

        //karra jadvali:
        for (int i = 1; i < 10; i ++)
        {
            for (int j = 1; j < 10; j ++)
            {
                System.Console.WriteLine($"{i}x{j}={i*j}");
            }
            System.Console.WriteLine();
        }

    }
}