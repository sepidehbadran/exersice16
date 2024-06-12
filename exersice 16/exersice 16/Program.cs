// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first side of the triangle: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second side of the triangle: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third side of the triangle: ");
int third = Convert.ToInt32(Console.ReadLine());

if (first + second>third && first + third>second && second + third > first)
{
 // Console.WriteLine("yes");
 if (first==second && second == third)
    {
        Console.WriteLine("111");
    }
    else if(first==second || second==third || first == third)
    {
        Console.WriteLine("112");
    }
    else
    {
        Console.WriteLine("123");
    }  
}
else
{
    Console.WriteLine("no");
}

