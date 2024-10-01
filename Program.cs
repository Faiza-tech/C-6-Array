/*
#What is an array?
An array is a collection of individual data elements accessible through a single variable name. You use a zero-based numeric index to access each element of an array. Arrays allow you to create a collection of data values that shares a common purpose or characteristics under a single variable name for easier processing.

#Declaring arrays and accessing array elements
An array is a special type of variable that can hold multiple values of the same data type. The declaration syntax is slightly different for an array because you have to specify both the data type and the size of the array.
*/

//Declare a new array
string[] fraudulentOrderID = new string[3];

//The new operator creates a new instance of an array in the computer's memory that can hold three string values. For more information about the new keyword
//Notice that the first set of square brackets [] merely tells the compiler that the variable named fraudulentOrderIDs is an array, but the second set of square brackets [3] indicates the number of elements that the array can hold.

//Assign values to elements of an array
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000"; we cannot write this bcz array start from zero not 1

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//Reassign the value of an array
//The elements of an array are just like any other variable value. You can assign, retrieve, and reassign a value to each element of the array.
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine("*****************************");
Console.WriteLine("");

//Initialize an array
string[] fraudOrderIDs = [ "A123", "B456", "C789" ];


Console.WriteLine($"First ID: {fraudOrderIDs[0]}");
Console.WriteLine($"Second ID: {fraudOrderIDs[1]}");
Console.WriteLine($"Third ID: {fraudOrderIDs[2]}");

fraudOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First ID: {fraudOrderIDs[0]}");

//Use the Length property of an array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

Console.WriteLine("*****************************");
Console.WriteLine("");

//another example
int[] myArray = [1,2,3];
Console.WriteLine($"First item in Array: {myArray[0]}");
Console.WriteLine($"Second item in Array: {myArray[1]}");
Console.WriteLine($"Third item in Array: {myArray[2]}");
