Console.WriteLine($"Today is: {DateTime.Now}");

DayOfWeek weekDay = DateTime.Today.DayOfWeek;

if(weekDay == DayOfWeek.Monday)
{
    Console.WriteLine("A fresh start, a clean slate, and a lot of potential for great things to come. That is what Mondays really are.");
}
else if(weekDay == DayOfWeek.Tuesday)
{
    Console.WriteLine("Tuesday is a terrific day because it means that I got through Monday.");
}
else if (weekDay == DayOfWeek.Wednesday)
{
    Console.WriteLine("Today is Wednesday, which means that we are halfway to the weekend.");
}
else if (weekDay == DayOfWeek.Thursday)
{
    Console.WriteLine("Today is Thursday? Whoopee, that means that Friday is almost here!");
}
else if (weekDay == DayOfWeek.Friday)
{
    Console.WriteLine("You have worked hard during the whole week. It’s time to relax and have a good time with your friends and family. Happy Friday!");
}
else
{
    Console.WriteLine("The weekend is here. Not just for you, but for your shoes, suits, and laptop as well. So give yourself and your things some rest. I hope you have a great weekend.");
}