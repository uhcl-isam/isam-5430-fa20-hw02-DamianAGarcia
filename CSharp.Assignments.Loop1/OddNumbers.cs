﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. 
        /// Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// 
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            // Codes to enter start
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Error.WriteLine("Enter the ending number");
            // Codes to enter end.
            int end = Convert.ToInt32(Console.ReadLine());
            if (start > end)
            {
                Console.WriteLine("Invalid, no numbers to order.");
            }
            else
                while(start < end)
                {
                    if (start % 2 != 0)
                    {
                        Console.WriteLine(start);
                    }
                start++;
                }
        }
    }
}
