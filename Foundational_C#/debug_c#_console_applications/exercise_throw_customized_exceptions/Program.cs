﻿// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

try
{
  // Calculate the sum of the even numbers between the bounds
  averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

}
catch (ArgumentOutOfRangeException ex)
{

  System.Console.WriteLine(ex.Message);

}

// Display the value returned by AverageOfEvenNumbers in the console
Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
try
{
  
  if (lowerBound > upperBound)
  {
    throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
  }
  int sum = 0;
  int count = 0;
  decimal average = 0;

  for (int i = lowerBound; i <= upperBound; i++)
  {
    if (i % 2 == 0)
    {
      sum += i;
      count++;
    }
  }

  average = (decimal)sum / count;
  string testNull = null;
  System.Console.WriteLine(testNull);
  return average;
  
}
catch (System.Exception ex)
{
  
  throw;
}
}