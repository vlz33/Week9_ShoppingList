using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingList.txt
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Ville\Desktop\KOOL\Programmeerimine\Nädal 8 failid\shopping list";
            string fileName = @"\\myshoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Add an item? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care");
                }
            }

            Console.Clear();
            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Your items: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);

        }
    }
}
