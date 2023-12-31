﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the arrays:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            
            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < size; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine("Enter values for the second array:");
            for (int i = 0; i < size; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i] + array2[i];
            }

            
            int[] vectorSumArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorSumArray[i] = array1[i] + array2[i];
            }

            
            int[] vectorProductArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorProductArray[i] = array1[i] * array2[i];
            }

            
            int[] scalarProductArray = new int[size];
            int scalarProductSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarProductArray[i] = array1[i] * array2[i];
                scalarProductSum += scalarProductArray[i];
            }

            
            Console.WriteLine("Scalar Sum: " + scalarSum);
            Console.WriteLine("Vector Sum:");
            foreach (int value in vectorSumArray)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Vector Product:");
            foreach (int value in vectorProductArray)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Scalar Product: " + scalarProductSum);

            Console.ReadLine(); 
        }
    }
}
