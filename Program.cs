Console.WriteLine("Week 6 Day 2");
// 2. Pattern Printing.

Console.WriteLine("Pattern Printing");
Console.WriteLine("Enter the number of rows:");
int rows = int.Parse(Console.ReadLine());

for(int i = 1; i <= rows; i++)
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}



// 1. Menu System for temperature.


Console.WriteLine("Temperature Conversion Menu");
Console.WriteLine("1.Convert Celsius to Fahrenheit");
Console.WriteLine("2.Convert Fahrenheit to Celsuis");
Console.WriteLine("3.Convert Celsius to Kelvin");
Console.WriteLine("4.Exit");

// while true, use the break statement.
// declare a boolean with true. 
while (true)
{
    // print the statement.
    Console.WriteLine("Enter your choice(1/2/3/4)");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1)
    {
        // F = (C*9/5) + 32
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (double)(celsius * (9 / 5)) + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}°F"); //alt+0176
    }else if(choice == 2) {
        // something
        Console.WriteLine("Enter temperature in Fahrenheit:");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (double)(((fahrenheit - 32) *5) / 9);
        Console.WriteLine($"Temperature in Celsius: {celsius}°C"); //alt+0176

    }
    else if(choice == 3)
    {
        // something
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine());
        double kelvin = celsius + 273.15;
        Console.WriteLine($"Temperature in Kelvin: {kelvin}");
    }
    else if(choice == 4)
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}