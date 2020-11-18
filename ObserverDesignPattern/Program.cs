﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //********Create subject***********
            //Create a Product with Out Of Stock Status
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            Console.WriteLine("Subject Red MI Mobile is created");
            Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
            Console.WriteLine();

            //******Create observer and register to the subject********
            //User Anurag will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Anurag", RedMI);
            //User Pranaya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Pranaya", RedMI);
            //User Priyanka will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Priyanka", RedMI);
            Console.WriteLine("All the 3 observers are registered to subject");
            Console.WriteLine();

            // Now product is available
            RedMI.setAvailability("Available");
            Console.Read();
        }
    }
}
