Console.WriteLine("Please insert 6 numbers (1-100):");
int userNumA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please insert your second number:");
int userNumB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please insert your third number:");
int userNumC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please insert your fourth number:");
int userNumD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please insert your fifth number:");
int userNumE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please insert your sixth number:");
int userNumF = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Numbers chosen. Computer generating numbers...");

Random rnd = new Random();
int ComputerNumA = rnd.Next(1, 101);
int ComputerNumB = rnd.Next(1, 101);
int ComputerNumC = rnd.Next(1, 101);
int ComputerNumD = rnd.Next(1, 101);
int ComputerNumE = rnd.Next(1, 101);
int ComputerNumF = rnd.Next(1, 101);

Console.WriteLine(ComputerNumA);
Console.WriteLine(ComputerNumB);
Console.WriteLine(ComputerNumC);
Console.WriteLine(ComputerNumD);
Console.WriteLine(ComputerNumE);
Console.WriteLine(ComputerNumF);