Console.WriteLine("Enter a number");
int num=Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
    Console.WriteLine($"{num} is even");// true
}
else
{
    Console.WriteLine($"{num} is odd"); // false
}

Console.WriteLine("Sample text added");