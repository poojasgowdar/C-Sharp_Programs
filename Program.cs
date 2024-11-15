﻿using System;


namespace SeconSmallestArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min1, min2, n, i;
            int[] arr = new int[55];

            Console.Write("Enter the Size of an Array:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + n + " Elements :");
            for (i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (arr[0] < arr[1])
            {
                min1 = arr[0];
                min2 = arr[1];
            }
            else
            {
                min1 = arr[1];
                min2 = arr[0];
            }

            for (i = 2; i < n; i++)
            {
                if (arr[i] < min1)
                {
                    min2 = min1;
                    min1 = arr[i];
                }
                else if (arr[i] < min2)
                {
                    min2 = arr[i];
                }
            }
            Console.WriteLine("Smallest Element is:" + min1);
            Console.WriteLine("Second Smallest Element is:" + min2);

            Console.WriteLine(min2);
            Console.ReadLine();
        }
    }
}
