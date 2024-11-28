
//input
string day = Console.ReadLine();
int customerAge = int.Parse(Console.ReadLine());
int ticketPrice = 0;
if (customerAge <= 0 && customerAge <= 18)
{
	switch (day) 
	{
		case "Weekday":
            ticketPrice = 12;
			break;
        case "Weekend":
            ticketPrice = 15;
            break;
        case "Holiday":
            ticketPrice = 5;
            break;
       
	}
}
else if (customerAge > 18 && customerAge <= 64)
{
    switch (day)
    {
        case "Weekday":
            ticketPrice = 18;
            break;
        case "Weekend":
            ticketPrice = 20;
            break;
        case "Holiday":
            ticketPrice = 12;
            break;
    }
}
else if (customerAge > 64 && customerAge <= 122)
{
    switch (day)
    {
        case "Weekday":
            ticketPrice = 12;
            break;
        case "Weekend":
            ticketPrice = 15;
            break;
        case "Holiday":
            ticketPrice = 10;
            break;
    }
}
else
{
    Console.WriteLine("Error!");
}

Console.WriteLine($"{ticketPrice}$");