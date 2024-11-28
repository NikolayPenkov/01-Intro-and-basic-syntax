using System;
//Create a program that receives an integer as an input. 
//Print the 10 times table for this integer. See the examples below for more information.
//{theInteger} X {times} = {product}

int integer= int.Parse(Console.ReadLine());
int times = 1;
while (times <= 10)
{
    int product = integer * times;
    Console.WriteLine($"{integer} x {times} = {product}");

    times++;
}