//Create a program, that receives a single number as an input representing a grade.
//Print to the console:
//•	"Passed!" if the grade is equal or more than 3.00. 
//The output is either "Passed!" if the grade is equal or more than 3.00, otherwise you should print nothing.

double grade = double.Parse(Console.ReadLine());

if (grade >= 3.00)
{
    Console.WriteLine("Passed!");
}