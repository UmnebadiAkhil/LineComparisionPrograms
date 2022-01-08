// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n Hello, World!");
Console.WriteLine("\n Welcome to Line Comparison Computation Program on Master Branch");

Console.WriteLine("Enter X1 value :-");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y1 value :-");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter X2 value :-");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y2 value :-");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n ---------------------------------------------------------------\n ");
LineComparisonProblem.UC1.LengthOfLine(X1, X2, Y1, Y2);
Console.WriteLine("\n ---------------------------------------------------------------\n ");
LineComparisonProblem.US_2.Equals(X1, X2, Y1, Y2);
Console.WriteLine("\n ---------------------------------------------------------------\n ");
LineComparisonProblem.UC_3.Comparision(X1, X2, Y1, Y2);