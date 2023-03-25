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

        
    }
}