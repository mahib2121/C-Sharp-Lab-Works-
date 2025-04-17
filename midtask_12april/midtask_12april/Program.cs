using System;


public class FinancialMathAssistant
{
    
    public int CalculateTotal(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    
    public void AdjustBalance(ref int balance, int addedAmount)
    {
        balance += addedAmount;
    }

    
    public void FindMaxMin(int[] numbers,  out int high, out  int low)
    {
        high = numbers[0];
        low = numbers[0];

        foreach (int num in numbers)
        {
            if (num > high)
                high = num;
            if (num < low)
                low = num;
        }

    }
}


public class Program
{
    public static void Main()
    {
        FinancialMathAssistant a= new FinancialMathAssistant();

        //CalculateTotal
        int total = a.CalculateTotal(10, 20, 30);
        Console.WriteLine($"Calculating sum of 10, 20, 30 gives:{total} ");

       // AdjustBalance
        int balance = 0;
        a.AdjustBalance(ref balance, total);
        Console.WriteLine($"Balance after adding {total}: {balance}");

        a.AdjustBalance(ref balance, 40);
        Console.WriteLine($"Balance after adding 40: {balance}");

        // FindMaxMin
        int[] values = { 10, 20, 30, 40 };
        a.FindMaxMin(values, out int max,  out int min);
        Console.WriteLine($"From the array [10, 20, 30, 40], the Highest: {max}, Lowest: {min}");
    }
}
