Console.WriteLine("Please enter your first number: ");
string input1Str = Console.ReadLine();

Console.WriteLine("Please enter your second number: ");
string input2Str = Console.ReadLine();

int input1 = int.Parse(input1Str);
int input2 = int.Parse(input2Str);
int sum = (input1 + input2);

Console.WriteLine($"The first number was: {input1}");
Console.WriteLine($"The second number was: {input2}");
Console.WriteLine($"The sum is: {sum}");