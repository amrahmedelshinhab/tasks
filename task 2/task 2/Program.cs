
/*
  //Create a program that calculates the following using variables x = 15 and y = 4:




//namespace task_2
//{
//    using System;

//    class Program
//    {
//        static void Main()
//        {

//            int x = 15;
//            int y = 4;


//            int sum = x + y;
//            int difference = x - y;
//            int product = x * y;
//            int divisionResult = x / y;
//            int remainder = x % y;


//            Console.WriteLine("Sum: " + sum);
//            Console.WriteLine("Difference: " + difference);
//            Console.WriteLine("Product: " + product);
//            Console.WriteLine("Division result: " + divisionResult);
//            Console.WriteLine("Remainder: " + remainder);
//        }
//    }

//}
/*


/*explaining its purpose: 
int x = 10; Declares an integer variable x and initializes it with the value 10.

int y = 20; Declares an integer variable y and initializes it with the value 20.

int sum = x + y; Adds the values of x and y and stores the result in a new integer variable sum.

Console.WriteLine(sum); utputs the result of the addition (sum) to the console.

/*
Problem: Declare variables using proper naming conventions to store: 

 Your full name. =string fullName = "amr elshinhab"; 

 Your age. = int age = 20;

 Your monthly salary.=decimal monthlySalary = 3500.50;

 Whether you are a student. bool Student = true;


*/

/*Problem: Write a program to demonstrate that changing the value of a reference type affects all 
references pointing to that object. 
Question: Explain the difference between value types and reference types in terms of memory 
allocation.  

using System;
class Program
{
class Person
{
public string Name { get; set; }
}

static void Main()
{

Person person1 = new Person() { Name = "Alice" };

Person person2 = person1;

person2.Name = "Bob";

Console.WriteLine("Person1 Name: " + person1.Name); // Output: Bob
Console.WriteLine("Person2 Name: " + person2.Name); // Output: Bob
}
}*/


/*Problem: Write a program that checks if a given number is both: 
o Greater than 10. 
o Even.


class Program
{
static void Main(string[] args)
{

Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());

if (number > 10 && number % 2 == 0)
{
    Console.WriteLine($"The number {number} is greater than 10 and even.");
}
else
{
    Console.WriteLine($"The number {number} does not meet the conditions.");
}
}
}
*/








//Problem: Implement a program that takes a double input from the user and casts it to an int. 
//Use both implicit and explicit casting, then print the results. 


//class Program
//{
//    static void Main()
//    {

//        Console.Write("Enter a double value: ");
//        double userInput = Convert.ToDouble(Console.ReadLine());


//        int explicitCast = (int)userInput;

//        Console.WriteLine($"Original double value: {userInput}");
//        Console.WriteLine($"After explicit casting to int: {explicitCast}");


//    }
//}


//Problem: Write a program that: (G01 Bonus, G02 mandatory)
//o Prompts the user for their age as a string. 
//o Converts the string to an integer using Parse
//o Checks if the age is valid (e.g., greater than 0). 


//class Program
//{
//    static void Main()
//    {

//        Console.Write("Please enter your age: ");
//        string ageInput = Console.ReadLine();

//        try
//        {
//            int age = int.Parse(ageInput);

//            if (age > 0)
//            {
//                Console.WriteLine($"Your age is {age}.");
//            }
//            else
//            {
//                Console.WriteLine("Invalid age. Age must be greater than 0.");
//            }
//        }
//        catch (FormatException)
//        {

//            Console.WriteLine("Invalid input. Please enter a valid number.");
//        }
//    }
//}




/*
Problem: Write a program that demonstrates the difference between prefix and postfix 
increment operators using a variable x.

namespace ConsoleApp2
{
    using System;

    class Program
    {
        static void Main()
        {
            int x = 5;

            Console.WriteLine(" x: " + x);
            Console.WriteLine(" (++x): " + (++x));
            Console.WriteLine(" x : " + x);


            x = 5;
            Console.WriteLine("\n x : " + x);


            Console.WriteLine(" (x++): " + (x++));
            Console.WriteLine(" x : " + x);
        }
    }
}

*/
