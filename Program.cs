﻿using System;

namespace DSA1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var name = new Structs("Wassem","Darkwa");
            Console.WriteLine(name.Initials());
        }
    }
}