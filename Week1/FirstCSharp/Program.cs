// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, Dotnet Ninjas!");

//! Data Types

//? What is a statistically typed language ?
//? you have to specify the type of variables or function you want to create
//! JavaScript 
//? var name = "Wael"

//! C# 
string name = "Wael";
int number = 7;
double dec = 3.14;
float FloatValue = 1.2f;
bool isTrue = true;


Console.WriteLine(name);

//! List && Dictionaries
//? Arrays and Lists
// Array are fixed length 
string[] groceryList = new string[4];
//? [null,null,null,null]
string[] groceryList2 = { "Carrots", "Turkey", "Bread", "Milk" };
// ----------------------- 0            1        2       3

groceryList[2] = "Ham";
//? [null,null,"Ham",null]
Console.WriteLine(groceryList[2]);
Console.WriteLine(groceryList2[2]);
Console.WriteLine("it will change from this line ");
groceryList2[2] = "Ham";
Console.WriteLine(groceryList2[2]);

//? List is variable length
//! JS var numberList = [];
List<int> numberList = new List<int>();
//? Add to our List
numberList.Add(3);
numberList.Add(4);
numberList.Add(1);
numberList.Add(2);
numberList.Add(0);
numberList.Add(5);

//? First Parameter is the index, seconde is the value
numberList.Insert(1, 10000);
foreach (int i in numberList)
{
    Console.WriteLine(i);

}
//? Remove from List
numberList.RemoveAt(2);
numberList.Remove(0);
Console.WriteLine("--------------------------");
foreach (int i in numberList)
{
    Console.WriteLine(i);

}

//! String vs Char 
//? Strings contains multiple letters
string words = "Hello";

//? Char only contains 1 Letter
//! And specifically uses single quotations
char singleChar = 'C';


//!----------------Functions
//?--------------Parameters
static int DoMath(int x, int y)
{
    return x + y;

}

//?--Arguments
DoMath(5, 4);
Console.WriteLine("-----------Return---------------");
Console.WriteLine(DoMath(85, 74));

static void SayHello()
{
    Console.WriteLine("Hello Dotnet");
}
Console.WriteLine("-----------Void---------------");
SayHello();





