using System;
using System.Collections.Generic;

/*
Compute the sum, or total, of the numbers in the list.

Compute the average of the numbers in the list.

Find the maximum, or largest, number in the list.
*/
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        int average = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
                numbers.Add(number);
            }
            
        }
        while (number != 0);

        foreach (int item in numbers){
            sum += item;
            average = sum / numbers.Count;
        }
        for (int i = 0; i < numbers.Count; i++){
            if(numbers[i] > largest){
                largest = numbers[i];
            }
        }
        
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");

        
        

        


    } 
}