//Rewrite the program from the previous task so it can receive the multiplier from the console.
//Print the table from the given multiplier to 10. If the given multiplier is more than 10 - print only one row with the integer,
//the given multiplier, and the product. See the examples below for more information.




int integer = int.Parse(Console.ReadLine());

int times = int.Parse(Console.ReadLine());
while (times <= 10)
{
    int product = integer * times;
    Console.WriteLine($"{integer} x {times} = {product}");

    times++;
}