

// CALL METHODS FROM THE .NET Class Library Using C#



/*
Random dice = new Random();
int roll = dice.Next(1, 100);
Console.WriteLine(roll);




Recap
To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), 
where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.
When calling a stateless method, you don't need to create a new instance of its class first.
When calling a stateful method, you need to create an instance of the class, and access the method on the object.
Use the new operator to create a new instance of a class.
An instance of a class is called an object.


int rolll = dice.Next(111, 200);
Console.WriteLine(dice.Next(111, 200));
Console.WriteLine();
*/



/*
int number = 7;
string text = "seven";
Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

In this example, you're invoking three separate overloaded versions of the WriteLine() method.

The first WriteLine() method uses a method signature that accepts an int parameter.
The second WriteLine() method uses a method signature that accepts zero input parameters.
The third WriteLine() method uses a method signature that accepts a string parameter.
*/





Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

/*
Output

Copy
First roll: 342585470
Second roll: 43
Third roll: 89

The first version of the Next() method doesn't set an upper and lower boundary, so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.

The second version of the Next() method specifies the maximum value as an upper boundary, so in this case, you can expect a random value between 0 and 100.

The third version of the Next() method specifies both the minimum and maximum values, so in this case, you can expect a random value between 50 and 100.

*/
Console.WriteLine();


Random rnd = new Random();

Console.WriteLine("Generating 10 random numbers:");

for (uint ctr = 1; ctr <= 10; ctr++)
    Console.WriteLine($"{rnd.Next(),15:N0}");

Console.WriteLine();


int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);



Console.WriteLine();

// Add decision logic to your code using 'if', 'else', and 'else if' statements in C#

Random hejmar = new Random();

int roll4 = hejmar.Next(1, 7);
int roll5 = hejmar.Next(1, 7);
/*int roll6 = hejmar.Next(1, 7);

int total = roll4 + roll5 + roll6;

if (total > 14)
{
    System.Console.WriteLine("You win!");
}

if (total < 15)
{
    System.Console.WriteLine("You lose!");
}

System.Console.WriteLine($"Tona roll: {roll4} + {roll5} + {roll6} = {total}");

Console.WriteLine();
*/


/*
What is a Boolean expression?
A Boolean expression is any code that returns a Boolean value, either true or false. The simplest Boolean expressions are simply the values true and false. 
Alternatively, a Boolean expression could be the result of a method that returns the value true or false. 
For example, here's a simple code example using the string.Contains() method to evaluate whether one string contains another string.

Other simple Boolean expressions can be created by using operators to compare two values. Operators include:

==, the "equals" operator, to test for equality
>, the "greater than" operator, to test that the value on the left is greater than the value on the right
<, the "less than" operator, to test that the value on the left is less than the value on the right
>=, the "greater than or equal to" operator
<=, the "less than or equal to" operator
and so on
*/

string nivis = "Hacsix monga ber male me re birin cole";
bool rastiyaWe = nivis.Contains("Hacsix");
System.Console.WriteLine(rastiyaWe);

if (nivis.Contains("cole"))
{
    System.Console.WriteLine("Ke ev derewan kirin disa dinin ci?");
}

//Because the message.Contains("fox") returns a true or false value, it qualifies as a Boolean expression and can be used in an if statement.

