// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// C# is the main language for .NET development
// C# is an Object-oriented and a type-safe prgramming language

Console.WriteLine("Hello everybody"); // This is an example of a C# statement
Console.WriteLine("Please enter your name: ");

string name; // Variable declaration statement
string surname;
surname = "Ndimande"; // In declaring/creating a variable, the '=' sign is called an assignment operator
name = Console.ReadLine();
Console.WriteLine($"Hello {name} {surname}");

// Running the application using cmd and its .exe file
// Go the project folder
// Open the bin folder
// Open the Debug folder
// Write cmd on the current folders url bar and press enter
// Once the command line open, add the name of your project's .exe file (with the file name extension) and press enter

// Learning c# on Microsoft Documents
// www.docs.microsoft.com/en-us/dotnet/csharp/

// C# Building Blocks
// C# Statements
/* 
  Actions that make the program and used to create actions
 - eg. such as declaring a variable
  Flow of the program
 - This is order by which statements are executed
 - By default this is done vertically
 -- That is 1st statement, followed by the 2nd and so on.
 -- Please note that user interaction may have the flow working differently
 - This order is called the 'Flow of Execution'
  Every statement ends with a semicolon

 *see example in line 7
*/

// C# Identifiers
/*
 - This refers to a name given to a declared variable
 - Identifiers start with a letter or underscore and can contain letters, digits and underscores
*/

// C# Comments
// This line is representing what is a 'single line comment' in c#
/*
 This line and following are representing what is a 'multiline comment' in C#
 As you can see this line also shows that it's a comment also
*/

// C# Keywords
// These cannot be used as 'Identifiers'
/* 
   int, in, class, using,while, new, null, if, case,
   ref, return, lock, long, string, struct, const, enum, void, etc
*/

// C# Variable
/*
   These are storage locations that hold a value
   These are then given a name (identifier) as it gives access to the value it holds

   Variables types examples
   integer, string, date, etc

   Creating a variable is done on a declaration statement
   *see example in line 10
   *This variable is of type 'string' with identifier as 'name'
   *The equal sign is called an 'assignment operator'. see line 12
   
   Using a variable
   * This is to insert variables in a C# statement
   * see example in line 14
*/