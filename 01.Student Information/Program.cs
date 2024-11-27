//Create a program that receives 3 lines of input:
//•	student name 
//•	age
//•	average grade. 
//Your task is to print all the info about the student in the following format: "Name: {student name}, Age: {student age}, Grade: {student grade}".

string studentName = Console.ReadLine();

int studentAge = int.Parse(Console.ReadLine());

double studentAverageGrade = double.Parse(Console.ReadLine());

string studentInformation = $"Name {studentName}, Age {studentAge}, Grade {studentAverageGrade:f2}";

Console.WriteLine(studentInformation);

