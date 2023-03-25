//CalculatR
// 25.03.2023


using CalculatR.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        Security security = new Security();
        Calculator calculator = new Calculator();

        security.CheckPassword();
        calculator.GetInput();

        //ternary
        string message = 
            calculator.IsFirstNumberPositive() 
            ? "\n1st number is not positive!" 
            : "\n1st number is positive!";
        System.Console.WriteLine(message);

        calculator.CompareInput();
        string result = calculator.Calculate();
        System.Console.WriteLine($"\n{result}\n");
        calculator.PrintEvenNumbers();
        calculator.PrintMultipicationTable();

    }
}