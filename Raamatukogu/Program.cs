Console.WriteLine("Choose An Option:");
Console.WriteLine("1. Enter Book");
Console.WriteLine("2. Show Keywords");
Console.WriteLine("3. Show Library Info");
Console.WriteLine("4. Search By Keyword");
int chosenOption = Convert.ToInt32(Console.ReadLine());

if (chosenOption == 1)
{
    Console.WriteLine("Enter Book Title:");
    Console.WriteLine("Example: Learning Python");
    string bookName = Console.ReadLine();
    if (bookName == "Learning Python")
    {
        Console.WriteLine("Title: Learning Python");
        Console.WriteLine("Author: Mark Lutz");
        Console.WriteLine("ISBN13: 9871449355730");
        Console.WriteLine("Publisher:  O'Reilly and Associates");
        Console.WriteLine("Edition, Year: 1st Edition, 2013");
        Console.WriteLine("Pages: 100");
        Console.WriteLine("Keywords: Python, Education");
        Console.WriteLine("Terminating...");
    }
    else
    {
        Console.WriteLine("Invalid Input, Terminating...");
    }
}
else if (chosenOption == 4)
{
    Console.WriteLine("Enter A Keyword:");
    string bookKW = Console.ReadLine();
    if (bookKW == "Python" || bookKW == "Education")
    {
        Console.WriteLine("Title: Learning Python");
        Console.WriteLine("Author: Mark Lutz");
        Console.WriteLine("ISBN13: 9871449355730");
        Console.WriteLine("Publisher:  O'Reilly and Associates");
        Console.WriteLine("Edition, Year: 1st Edition, 2013");
        Console.WriteLine("Pages: 100");
        Console.WriteLine("Keywords: Python, Education");
        Console.WriteLine("Terminating...");
    }
    else
    {
        Console.WriteLine("Invalid Input, Terminating...");
    }
}
else if (chosenOption == 3)
{
    Console.WriteLine("Current Library Books: Learning Python");
    Console.WriteLine("Terminating...");
}
else if (chosenOption == 2)
{
    Console.WriteLine("Keywords: Python, Education");
    Console.WriteLine("Terminating...");
}
else
{
    Console.WriteLine("Invalid Input, Terminating...");
}