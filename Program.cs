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



// We declare an array of type string, name it car;

string[] car = { "BMW", "BENZ", "Tesla", "Hyundai"}; // declare an array named car with values.
                                          // empty initialisation. (null or undefined)



// methods in arrays.
// get the length.
Console.WriteLine($"Length of array car: {car.Length}");

// ["BMW", "BENZ", "Tesla", "Hyundai"]
//   0        1       2        3

// to get the first element of the array.

Console.WriteLine($"The first element of the array: {car[car.Length - 1]}");


// define the values in this array we need to specify the size;
string[] car1 = new string[3]; // declare an array with a name car1 of size 5
Console.WriteLine("Enter car name");
//car1[0] = Console.ReadLine();
//car1[1] = Console.ReadLine();
//car1[2] = Console.ReadLine();

for(int i = 0; i < car1.Length; i++)
{
    Console.WriteLine("Enter car value");
    car1[i] = Console.ReadLine();
} // this is how we add values to the array.

// printing an array.

for(int i = 0;i < car1.Length; i++)
{
    Console.WriteLine($"Car: {car1[i]}"); // print all values of array.
}
// 1. to make an array of type int, with a size of 10 and ask the user to input the values.

int[] array = new int[10];

for (int i=0;i<array.Length;i++) {
    Console.WriteLine("Enter value");
    array[i] = int.Parse(Console.ReadLine());   
}// get user input.

// print the values of the array.

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Value of array at index {i+1} is {array[i]}");
}


// to create an array of size 
int[] new_array = { 1,2,3,4,5};
Console.WriteLine(new_array[2]);

for(int i = 0; i < new_array.Length; i++)
{
    if (new_array[i]%2 == 0)
    {
        Console.WriteLine(new_array[i]);
    }
}

// 3. Print the sum of all elements in the array.
int sum = 0;
for(int i=0;i<new_array.Length; i++)
{
    sum = sum + new_array[i];
}
Console.WriteLine(sum);

//4. to print the maximum element in the array.

int max = -1;
for(int i = 0; i < new_array.Length; i++)
{
    if (new_array[i] > max)
    {
        max = new_array[i];
    }
}
Console.WriteLine("Max elemet in the array."+max);

//5. to count all even numbers in the array.
int evenCount = 0;
for(int i = 0; i < new_array.Length; i++)
{
    if (new_array[i] % 2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine("Number of even numbers present in the array is: "+ evenCount);

// 6. to check to a specific value if it exists.
Console.WriteLine("to check to a specific value if it exists.");
int check = int.Parse(Console.ReadLine());
int count = 0;
for(int i=0;i<new_array.Length; i++)
{
    if (new_array[i] == check)
    {
        count++;
    }
}

if (count > 0)
{
    Console.WriteLine("It exists");
}
else
{
    Console.WriteLine("Doesnt Exist");
}