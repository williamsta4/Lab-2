string input = String.Empty;
int num1, num2;
Console.WriteLine("Add +, Subtract -, Mutiply *, Divide /, % Modulus %");
Console.WriteLine("Type 'esc' to quit");
input = Console.ReadLine();
while (input!= "esc")
{  
    Console.WriteLine("Please enter your first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case "+":
            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"= {num1 + num2}");
            break;

        case "-":
            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"= {num1 - num2}");
            break;

        case "*":
            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"= {num1 * num2}");
            break;

        case "/":
            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"= {num1 / num2}");
            break;

        case "%":
            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"= {num1 % num2}");
            break;
    }
    Console.WriteLine("Add +, Subtract -, Mutiply *, Divide /, % Modulus %");
    Console.WriteLine("Type 'esc' to quit");
    input = Console.ReadLine();
} 