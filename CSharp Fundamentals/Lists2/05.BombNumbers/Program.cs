﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int specialBombNumber = bombData[0];
            int power = bombData[1];

            int bombIndex = list.IndexOf(specialBombNumber);

            while (bombIndex != -1)
            {
                int leftNumbers = bombIndex - power;
                int rightNumbers = bombIndex + power;

                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }
                if(rightNumbers > list.Count - 1)
                {
                    rightNumbers = list.Count - 1;
                }

                list.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);

                bombIndex = list.IndexOf(specialBombNumber);
            }

            int sum = list.Sum();

            Console.WriteLine(sum);
        }
    }
}
