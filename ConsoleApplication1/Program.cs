using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array; //declearing an array to store the input on it later on
            array = new int[99999];
            int number, total=0, count = 0, sum=0, min=99999, max=0;  //declearing the integers
            float average;  //declearing the average as a float to get the exact answer
            Console.WriteLine("Please enter a positive numbers, when done please enter a negatie value."); //printing to console 
            for (count = 0; count < 99999; count++) //loop to get the input
            {
                Console.Write("Input a number: ");  //prompting the user to input
                string rowInput = Console.ReadLine();  //reading off the user
                number = Convert.ToInt32(rowInput);   //converting it to intgeres
                array[count] = number;  //loading in the numbers into the string to display it later on
                
                if (number < 0)
                {
                    break;  //breaking the loop if the user enter a negative number
                }
                sum = sum + number;
                if (number > max)  //finding max number
                {
                    max = number;
                }
                if (number < min)  //finding min number
                {
                    min = number;
                }
                total++;  //recording the total
            }
            average = (float)sum / (float)count;
            //print out to console the results
            Console.Write("The total number of values: ");
            Console.WriteLine(total);
            Console.Write("Sum of values: ");
            Console.WriteLine(sum);
            Console.Write("Average of values: ");
            Console.WriteLine(average);
            Console.Write("Minimum value: ");
            Console.WriteLine(min);
            Console.Write("Maximum value: ");
            Console.WriteLine(max);
            Console.Write("Values entered: ");
            for (count = 0; count < total; count++)
            {
                Console.Write(array[count]);
                Console.Write(" ");  //printing a space between each number displayed on the values entered
            }
        }
    }
}
