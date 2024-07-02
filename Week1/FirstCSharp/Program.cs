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
// List is variable length







