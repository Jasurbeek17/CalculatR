namespace CalculatR.Classes
{
    class Calculator 
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void GetInput()
        {
            Console.Write("\nEnter first number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation (+, -, *, /, %): ");
            Operation = Console.ReadLine();
            Console.Write("Enter second number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public bool IsFirstNumberPositive()
        {
            return !(FirstNumber >= 0);
        }

        public void CompareInput()
        {
            if (FirstNumber > SecondNumber)
        {
            Console.WriteLine("\n1st number is greter than 2nd number.");
        }
        else if (FirstNumber == SecondNumber)
        {
            Console.WriteLine("\n1st number is equal to 2nd number.");
        }
        else
        {
            Console.WriteLine("1st number is less than 2nd number.");
        }
        }

        public string Calculate()
        {
            return Operation switch
        {
            "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
            "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
            "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
            "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
            "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
            _ => "Operation not found!"
        };
        }

        public void PrintEvenNumbers()
        {
            System.Console.WriteLine("\nPrinting even numbers tell first input...\n");
            int count = 2;
            while(count < FirstNumber)
            {
                System.Console.WriteLine(count);
                count += 2;
            }
            Console.WriteLine();
        }

        public void PrintMultipicationTable()
        {
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
}