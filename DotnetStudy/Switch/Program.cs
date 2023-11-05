// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


string dayOffWeek = DateTime.Now.DayOfWeek.ToString();
//if (dayOffWeek == "Monday")
//{
//    Console.WriteLine("This is Monday.");
//}
//else if(dayOffWeek=="Tuesday")
//{
//    Console.WriteLine("This is Tuesday.");
//}
//else if (dayOffWeek == "Wednesday")
//{
//    Console.WriteLine("This is Wednesday.");
//}
//else if (dayOffWeek == "Thursday")
//{
//    Console.WriteLine("This is Thursday.");
//}
//else if (dayOffWeek == "Friday")
//{
//    Console.WriteLine("This is Friday.");
//}
//else if (dayOffWeek == "Satuarday")
//{
//    Console.WriteLine("This is Friday.");
//}
//else if (dayOffWeek == "Sunday")
//{
//    Console.WriteLine("This is Sunday.");
//}


switch (dayOffWeek)
{
    case ("Monday"):
        Console.WriteLine("This is Monday.");
        break;
    case ("Tuesday"):
        Console.WriteLine("This is Tuesday.");
        break;
    case ("Wednesday"):
        Console.WriteLine("This is Wednesday.");
        break;
    case ("Thursday"):
        Console.WriteLine("This is Thursday.");
        break;
    case ("Friday"):
        Console.WriteLine("This is Friday.");
        break;
    case ("Satuarday"):
        Console.WriteLine("This is Satuarday.");
        break;
  default: 
        Console.WriteLine("No correct date selected.");
        break;
}