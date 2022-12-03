Console.WriteLine("Enter number: ");
string number = Console.ReadLine();
 if (number.Length != 3)
  {
    Console.WriteLine ("not a three digit number");
    Console.WriteLine("Enter number: ");
    number = Console.ReadLine();
  }
Console.WriteLine(number[1]);