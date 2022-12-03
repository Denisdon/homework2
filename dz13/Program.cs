Console.WriteLine("Enter number: ");
string number = Console.ReadLine();
 if (number.Length != 3)
  {
    Console.WriteLine ("no third digit");
    return;
  }
Console.WriteLine(number[2]);