int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter numbers for index " + i + ":");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The numbers entered:");
for(int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Index " + i + ": " + numbers[i]);
}