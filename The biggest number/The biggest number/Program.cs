using System;

class Program
{
    static void Main()
    {
        
        int[] numbers = { 21, 45, 38, 23, 59 };

        
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("The biggest number in the array is: " + max);
    }
}
