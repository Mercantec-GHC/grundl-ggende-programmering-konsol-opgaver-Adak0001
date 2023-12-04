using System;

Console.WriteLine("Hello World!\n");
Console.WriteLine("Hello World!");
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.\n");

Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");

Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");


Console.WriteLine('b');
//Notice that the letter b is surrounded with single quotation marks 'b'. Single quotes create a character literal.
//Recall that using double quotation marks creates a string data type.

Console.WriteLine(123);
Console.WriteLine(" ");
/*
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
*/

Console.WriteLine(0.25F);
/*
To create a float literal, append the letter F after the number. In this context, the F is called a literal suffix. 
The literal suffix tells the compiler you wish to work with a value of float type. 
You can use either a lower-case f or upper-case F as the literal suffix for a float.
*/

Console.WriteLine(2.625);
//To create a double literal, just enter a decimal number.--
//The compiler defaults to a double literal when a decimal number is entered without a literal suffix.


Console.WriteLine(" ");
Console.WriteLine(12.39816m);
//To create a decimal literal, append the letter m after the number.
//In this context, the m is called a literal suffix.
//The literal suffix tells the compiler you wish to work with a value of decimal type.
//You can use either a lower-case m or upper-case M as the literal suffix for a decimal.


Console.WriteLine(" ");
/*
Use Boolean literals
If you wanted to print a value representing either true or false, you could use a bool literal.

The term bool is short for Boolean. 
In C#, they're officially referred to as "bool", but often developers use the term "Boolean".
*/
Console.WriteLine(true);
Console.WriteLine(false);
Console.WriteLine(" ");


Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine(" ");

Console.WriteLine("true");
Console.WriteLine(true);

/*
The main takeaway is that there are many data types, but you'll focus on just a few for now:

string for words, phrases, or any alphanumeric data for presentation, not calculation
char for a single alphanumeric character
int for a whole number
decimal for a number with a fractional component
bool for a true/false value
*/


//Declare a variable
//To create a new variable, you must first declare the data type of the variable, and then give it a name.
string firstName;
firstName = "Adem";
Console.WriteLine(firstName);

firstName = "Bob";
Console.WriteLine(firstName);

firstName = "Liem";
Console.WriteLine(firstName);

firstName = "Isabella";
Console.WriteLine(firstName);

firstName = "Yasmin";
Console.WriteLine(firstName);



/*
Complete the challenge

In this challenge, you'll write code that will combine literal and variable values into a single message.

Challenge: Display literal and variable values

Store the following values in variables:

Bob
3
34.4
These variables should be given names that reflect their purpose.

Make sure you select the correct data type for each of the variables based on the type of data it will hold.

Finally, you'll combine the variables with literal strings passed into a series of Console.Write() commands to form a complete message.

Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
*/
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
Console.WriteLine(" \n");


/*
 * Character escape sequences
An escape character sequence is an instruction to the runtime to insert a special character that will affect the output of your string. 
In C#, the escape character sequence begins with a backslash \ followed by the character you're escaping. 
For example, the \n sequence will add a new line, and a \t sequence will add a tab.

The following code uses escape character sequences to add newlines and tabs:
 */
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

//use the \" escape sequence:
Console.WriteLine("Hello \"World\"!");

Console.WriteLine("c:\\source\\repos");

//Format output using character escape sequences
//To create the mockup of the command line tool
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

/*
 Verbatim string literal
A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. 
To create a verbatim string, use the @ directive before the literal string.
*/
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
/*
 Recap

Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
Unicode characters may not print correctly depending on the application.
 */




//To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +.
string message = "Hello " + firstName;
Console.WriteLine(message);
string greeting = "Hello";
string _ = greeting + " " + firstName + "!";
Console.WriteLine(greeting);

/*
To interpolate two strings together, you create a literal string and prefix the string with the $ symbol. 
The literal string should contain at least one set of curly braces {} and inside of those characters you use the name of a variable.

Men kan også skriv som nedunder...

string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);
*/







/*
 Use string interpolation with multiple variables and literal strings

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

Output

Update to Windows 11
 */

//you can eliminate the temporary variable to store the message.
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");


//You can use both the verbatim literal prefix symbol @ and the string interpolation $ symbol together.
string projectNName = "First-Project";
Console.WriteLine($@"C:\Output\{projectNName}\Data");
//In this example, the $ symbol allows you to reference the projectName variable inside the braces, 
//while the @ symbol allows you to use the unescaped \ character.


// Set console output encoding to UTF-8
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Unicode greeting message
string unicodeGreeting = "Hello สวัสดี こんにちは Здравствуйте";

// Display the greeting
Console.WriteLine(unicodeGreeting);

//"følgende som jeg har skrivet"

string projectName = "ACME";
Console.WriteLine(@"View English output:
        c:\Exercise\ACME\data.txt");

Console.WriteLine($@"Посмотреть русский вывод:
        c:\Exercise\ACME\ru-RU\data.txt");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

/*
 //"følgende som jeg har skrivet"

string projectName = "ACME";
Console.WriteLine(@"View English output:
        c:\Exercise\ACME\data.txt");

Console.WriteLine($@"Посмотреть русский вывод:
        c:\Exercise\ACME\ru-RU\data.txt");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

 ---------------------------------------------
"her er så the solution"
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
 */



/*
In this instance, the C# compiler understands what you're attempting to do. 
The compiler parses your code and sees that the + (the operator) is surrounded by two numeric values (the operands). 
Given the data types of the variables (both are ints), it figures out that you intended to add those two values.
 */
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);


/*
In this case, the C# compiler understands that you want to use the + symbol to concatenate the two operands. 
It deduces this because the + symbol is surrounded by operands of string and int data types. 
So, it attempts to implicitly convert the int variable widgetsSold into a string temporarily so it can concatenate it to the rest of the string.
The parentheses symbol () becomes another overloaded operator. In this case, the opening and closing parentheses form the order of operations operator, just like you might use in a mathematical formula. 
You indicate that you want the inner-most parentheses resolved first resulting in the addition of int values widgetsSold and the value 7. 
Once that is resolved, then it will implicitly convert the result to a string so that it can be concatenated with the rest of the message.
 */
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
int widgettsSold = 7;
Console.WriteLine(firstName + " sold " + (widgettsSold + 7) + " widgets.");

/*
Recap

You can perform mathematical-like addition operations on numbers.
Both string concatenation and addition use the plus + symbol. This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to concatenate the string representation of a number for presentation purposes.
Use parentheses to define an order of operations to explicitly tell the compiler that you want to perform certain operations before other operations.

+ is the addition operator
- is the subtraction operator
* is the multiplication operator
/ is the division operator
 */



int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal sayi1 = 7.0m;
int sayi2 = 5;
Console.WriteLine(sayi1 / sayi2);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");


/*
Write code to determine the remainder after integer division
The modulus operator % tells you the remainder of int division. What you really learn from this is whether one number is divisible by another. 
This can be useful during long processing operations when looping through hundreds or thousands of data records and you want to provide feedback to the end user after every 100 data records have been processed.
*/
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");



int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);
/*
Recap
Here's what you've learned so far about mathematical operations in C#:

Use operators like +, -, *, and / to perform basic mathematical operations.
The division of two int values will result in the truncation of any values after the decimal point. 
To retain values after the decimal point, you need to cast the divisor or dividend (or both) from int into a floating point number like decimal first, -
then the quotient must be of the same floating point type as well in order to avoid truncation.
Perform a cast operation to temporarily treat a value as if it were a different data type.
Use the % operator to capture the remainder after division.
The order of operations will follow the rules of the acronym PEMDAS.
*/


/*
Increment and decrement
Frequently, you'll need to increment and/or decrement values, especially when you're writing looping logic or code that interacts with a data structure.

The += operator adds and assigns the value on the right of the operator to the value on the left of the operator. 
So, lines two and three in the following code snippet are the same:
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

The ++ operator increments the value of the variable by 1. So, lines two and three in the following code snippet are the same:
int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.

*/


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
/*
 Note
In the "second increment", you used value += 1;. 
However you could have used any literal int value (or a variable) to increment that amount. 
The same holds true for the "second decrement": value -= 1;.

Increment the value.
Retrieve the new incremented value of the variable value and use that in the string operation.
While not strictly necessary, you added parenthesis around the expression (++value) to improve readability. 
Seeing so many + operators next to each other seems like it could be misunderstood by other developers. Stylistic decisions like this are subjective. 
However, since you'll write the code once but read it many times, you should prioritize readability.

Recap
Here's what you've learned so far about mathematical operations in C#:

Use compound assignment operators like +=, -=, *=, ++, and -- to perform a mathematical operation like increment or decrement, then assign the result into the original variable.
Increment and decrement operators perform differently depending on whether the operator is before or after the operand.

*/




int fahrenheit = 94;

double celsius = (fahrenheit - 32) * 5.0 / 9.0;

Console.WriteLine($"The temperature is {celsius:F1} Celsius.");


int first = 0;
Console.WriteLine(first);
Console.ReadLine();










