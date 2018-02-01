using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an interactive console window
            //Prompt user to choose what to do with the fridge
            //Call methods on Fridge object to do what the user wants

            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true); //this project does not give user choice of constructor to use
            int userChoice;
            do
            {

                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1.");
                Console.WriteLine("To change the lightbulb, type 2.");
                Console.WriteLine("To clean, type 3.");
                Console.WriteLine("To take food, type 4.");
                Console.WriteLine("To check food supplies, type 5.");
                Console.WriteLine("To see all fridge details, type 6.");
                Console.WriteLine("To restart, type 7.");
                Console.WriteLine("To quit, type 8.");

                userChoice = int.Parse(Console.ReadLine());

                

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;
                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;
                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;
                    case 4:
                        Console.WriteLine("How many units of food do you want to eat?");
                        int foodEaten = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodEaten);
                        break;
                    case 5:
                        Console.WriteLine("Supplies are " + userFridge.CheckSupplies());
                        break;
                    case 6:
                        Console.WriteLine("The fridge is clean " + userFridge.IsClean + ", the food supply is " + userFridge.FoodAmount + ", the bulb is working " + userFridge.BulbsWork + ", and dispenser type is " + userFridge.DispenserType);
                        break;
                    case 8:
                        Console.WriteLine("Goodbye");
                        break;


                        


                }

            } while (userChoice != 8);

        }
    }
    
}
