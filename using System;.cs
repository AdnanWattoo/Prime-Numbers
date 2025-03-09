
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            string result = IsPrime(num) ? "is" : "is not";
            Console.WriteLine($"{num} {result} a prime number.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
