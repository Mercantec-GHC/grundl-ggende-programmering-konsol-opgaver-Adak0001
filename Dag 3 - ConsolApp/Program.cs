/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"Frist: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

/*
Recap
Here's the most important things to remember when working with arrays:

An array is a special variable that holds a sequence of related data elements.
You should memorize the basic format of an array variable declaration.
Access each element of an array to set or get its values using a zero-based index inside of square brackets.
If you attempt to access an index outside of the boundary of the array, you get a run time exception.
The Length property gives you a programmatic way to determine the number of elements in an array.
*/

// Looping through an array using foreach
string[] names = { "Rowena", "Robin", "Kurdi" };
foreach (string name in names)
{
    Console.WriteLine(name);
}


// Create and initialize an array of int
//Create a variable to hold the current bin number and display the running total

int[] inventory = { 200, 450, 700, 175, 250  };
int sum = 0;
int bin = 0;
foreach (int items in inventory)

{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");


/*
Recap
Here's a few things to remember about foreach statements and incrementing values that you learned in this unit:

Use the foreach statement to iterate through each element in an array, executing the associated code block once for each element in the array.
The foreach statement sets the value of the current element in the array to a temporary variable, which you can use in the body of the code block.
Use the ++ increment operator to add 1 to the current value of a variable.
*/


string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);    
    }
    
}

//Here are some simple code examples written using a foreach loop:

// Performing Operations on the Array:
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// Acting on the List:
List<string> fruits = new List<string> { "apple", "banana", "cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

//Acting on Characters:
string word = "hello";
foreach (char letter in word)
{
    Console.WriteLine(letter);
}

//Operating on the Dictionary Structure:
Dictionary<string, int> ages = new Dictionary<string, int>() {
    { "Alice", 30 }, { "Bob", 25 }, { "Cathy", 27 }
};
foreach (KeyValuePair<string, int> kvp in ages)
{
    Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
}

