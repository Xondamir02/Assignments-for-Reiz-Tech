
Console.WriteLine("You can Enter Hours");

double hours = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("You can Enter Minutes");

double minutes = Convert.ToDouble(Console.ReadLine());



Degrees(hours, minutes);


 void Degrees(double hours, double minutes)
{
    if(hours < 0 || minutes < 0 || hours > 12 || minutes > 60)
    {
        Console.WriteLine("Please Enter correct format (0 < hours<=12 && 0 < minutes <=60 )");
    }
    if(hours==12)hours= 0;

    if (minutes == 60)
    {
        minutes= 0;
        hours += 1;
        if (hours > 12)
        {
            hours -= 12;
        }

    }

    double hourAngle = (hours * 60 + minutes) * 0.5;
    double minuteAngle = minutes * 6;

    double degree = Math.Abs(hourAngle - minuteAngle);

    degree = Math.Min(360 - degree, degree);

    Console.WriteLine($"Lesser degrees between {hours} hours and {minutes} minutes is {degree} °");

}

