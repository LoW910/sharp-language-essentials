using System;
using System.Collections.Generic;

namespace LanguageEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo!";
            Console.WriteLine("Hello World!");
            Console.WriteLine("First solo test ride of C#!");
            Console.WriteLine($"Going to {place}");
            Console.WriteLine("The Value of pi is " + 3.14159);
            Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // System.Console.WriteLine("************************************");

            // int start = 0;
            // int end = 5;
            // System.Console.WriteLine("i <= end");
            // for(int i = start; i <= end; i++){
            //     System.Console.WriteLine(i);
            // }
            
            
            
            System.Console.WriteLine("************************************");
            int start = 0;
            int end = 5;
            System.Console.WriteLine("i < end");
            for(int i = start; i < end; i++) {
                System.Console.WriteLine(i);
            }



            System.Console.WriteLine("*********************************");
            int r = 1;
            while (r < 6)
            {
                System.Console.WriteLine($"In while loop {r}" );
                r += 1;
            }


            Random rand = new Random();
            for(int val = 0; val < 10; val++){
                System.Console.WriteLine(rand.Next(2,8));
            }


            for(int twoFiveFive = 0; twoFiveFive <= 255; twoFiveFive++) {
                System.Console.WriteLine(twoFiveFive);
            }


            for(int oneHundred = 0; oneHundred <= 100; oneHundred++) {
                if (oneHundred % 3 == 0 && oneHundred % 5 != 0) {
                    System.Console.WriteLine($"divisible by 3 fizz {oneHundred}");
                } else if(oneHundred % 5 == 0 && oneHundred % 3 != 0) {
                    System.Console.WriteLine($"divisible by 5 buzz {oneHundred}");
                }
            }

            int [] numArray = new int[5];
            int [] numArray2 = {1,2,3,4,5};
            int [] array3;
            array3 = new int[] {1,3,5,7,9};

            string [] myCars = new string[] {"Mazda Miata", "Ford Model T", "POS Dodge", "Broke Nissan"};

            for(int idx = 0; idx < myCars.Length; idx++){
                System.Console.WriteLine($"I own a {myCars[idx]} in traditional for loop");
            }

            foreach (string car in myCars)
            {
                System.Console.WriteLine($"These are foreach cars i own... {car}");
            }


            List<string> bikes = new List<string>();

            bikes.Add("Kawasaki");
            bikes.Add("BMW");
            bikes.Add("Harley Davidson");
            bikes.Add("Moto Guzzi");
            bikes.Add("Suzuki");
            bikes.Add("Triumph");


            System.Console.WriteLine(bikes[2]);
            System.Console.WriteLine($"We know of {bikes.Count} motorcycle manufactures");



            System.Console.WriteLine("The current manufactures we have seen are: ");
            foreach (string bike in bikes)
            {
                System.Console.WriteLine(bike);
            }



            Dictionary<string, string> profile = new Dictionary<string, string>();

            profile.Add("Name", "Speros");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            System.Console.WriteLine("Instructor Profile");
            System.Console.WriteLine("Name - " + profile["Name"]);
            System.Console.WriteLine("From - " + profile["Location"]);
            System.Console.WriteLine("Favorite Language - " + profile["Language"]);

            System.Console.WriteLine("*******************************************");
            foreach (KeyValuePair<string,string> entry in profile)
            {
                System.Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            System.Console.WriteLine("*******************************************");
            foreach (var newEntry in profile)
            {
                System.Console.WriteLine(newEntry.Key + " ++ " + newEntry.Value);
            }






















        }
        
    }
}
