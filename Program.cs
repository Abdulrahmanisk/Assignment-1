// String red;
// String green;
// String yellow;

// Console.WriteLine("Please Enter Your First Name: ");
// red = Console.ReadLine();
// Console.Beep();

// Console.WriteLine("Please Enter Your Middle Name: ");
// green = Console.ReadLine();
// Console.Beep();

// Console.WriteLine("Please Enter Your Last Name: ");
// yellow = Console.ReadLine();
// Console.Beep();

// int labelWidth = 12;

// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine($"{"First Name:".PadRight(labelWidth)} {red}");
// Console.ResetColor();
// Console.Beep();

// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine($"{"Middle Name:".PadRight(labelWidth)} {green}");
// Console.ResetColor();
// Console.Beep();

// Console.ForegroundColor = ConsoleColor.Yellow;
// Console.WriteLine($"{"Last Name:".PadRight(labelWidth)} {yellow}");
// Console.ResetColor();
// Console.Beep();




// using System.Diagnostics;

// int a = int.MaxValue;
// int b = byte.MaxValue;

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(a + b);
// Console.WriteLine(a * b);
// Console.WriteLine(a % b);
// Console.WriteLine(a - b);



// Console.WriteLine(Math.PI);

// int absValue = Math.Abs(-123);
// Console.WriteLine(absValue);


// int Value = Math.Min(10, 5);
// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine("Minimum " + Value);
// Console.ResetColor();

// int Value2 = Math.Max(10, 5);
// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("Maximum " + Value2);
// Console.ResetColor();



// int health = 101;
// health = Math.Clamp(health, 0, 100);
// Console.WriteLine(health);


var x = 0;
var y = 0;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter your first number");
x = Convert.ToInt32(Console.ReadLine());
Console.Beep();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Enter your second number");
y = Convert.ToInt32(Console.ReadLine());
Console.Beep();
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Enter the operation (+, -, *, /)");
var o = Console.ReadLine();
Console.Beep();
Console.ResetColor();

Console.ForegroundColor= ConsoleColor.Blue;
if (o == "+") {
    Console.WriteLine(x + y);
} else if (o == "*") {
    Console.WriteLine(x * y);
} else if (o == "-") {
    Console.WriteLine(x - y);
} else if (o == "/") {
    Console.WriteLine(x / y);
} else {
    Console.WriteLine("invalid operator");
}
Console.Beep();
Console.ResetColor();

