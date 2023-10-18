Console.WriteLine("Hello, World!");
Console.WriteLine('b');
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);
Console.WriteLine(true);
Console.WriteLine(false);
Console.WriteLine("123");
Console.WriteLine(123);
Console.WriteLine("true");
Console.WriteLine(true);
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);
Console.WriteLine(3);
Console.WriteLine("34,4");
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;
Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");
Console.WriteLine(34.40M);Console.WriteLine(34.40M);
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
Console.Write(@"c:\invoices");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
string message = "Hello " + firstName;
Console.WriteLine(message);
string greeting = "Hello";
string _ = greeting + " " + firstName + "!";
Console.WriteLine(message);
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"View English output:\n  c:\\Exercise\\{projectName}\\data.txt");
Console.WriteLine($"{russianMessage}:\n  c:\\Exercise\\{projectName}\\ru-RU\\data.txt");
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

int fahrenheit = 94;

double celsius = (fahrenheit - 32) * 5.0 / 9.0;

Console.WriteLine($"The temperature is {celsius:F1} Celsius.");
