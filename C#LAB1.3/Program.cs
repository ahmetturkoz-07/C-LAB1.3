Console.Write("Enter student name: ");
string name = Console.ReadLine()!;

Console.Write("Enter midterm score: ");
double midterm = double.Parse(Console.ReadLine()!);

Console.Write("Enter final score: ");
double final = double.Parse(Console.ReadLine()!);

double average = midterm * 0.4 + final * 0.6;

Console.WriteLine($"{name}, your average is {average:F2}");

if (average >= 50)
{
    Console.WriteLine("Result: PASSED");
}
else
{
    Console.WriteLine("Result: FAILED");
}