Console.WriteLine("Please enter your first number you want to multiply by: ");
string input1Str = Console.ReadLine();

Console.WriteLine("Please enter the highest number you want to multiply to: ");
string input2Str = Console.ReadLine();

int input1 = int.Parse(input1Str);
int input2 = int.Parse(input2Str);
int sum = (input1 + input2);
int n = input2;
for(int i=0; i<=n; i++)
{
    Console.Write("{0} X {1} = {2} \n", n, i, n * i);
}