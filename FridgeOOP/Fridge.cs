using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge
    {
        //fields =="baby bears"
        private bool isClean;//I dont want the variable to able to be manipulated outside of this...camel case
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;
        //Properties===="mama bear" get/set.......get allows us to see the value...set allows us to assign the value...pascal
        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }
        public string DispenserType  //we don't want user to be able to change the value
        {
            get { return this.dispenserType; }
            //set {return this.dispenserType = "basic water";}   in this instance every fridge instantiated would have this string 
        }
        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }
        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }
        //Constructors...always need a default, but EVERYTIME a fridge is instantiated we need a dispenser type
        public Fridge()
        {
            this.dispenserType = "basic water dispenser";     //since we didn't do a set in the property, we wanted to make sure that EVERY fridge still has a dispenser type.
        }
        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType; ///field on left from top of page, parameter on right is the one in parantheses
        }
        public Fridge(bool isClean, string dispenserType, int foodAmount, bool bulbsWork)
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;
        }
        //Methods()  focus on the MVP!
        //i need a way to dispense water
        //i need a way to change bulbs
        //i need a way to clean fridge
        //i need a way to check food supplies
        public void DispenseWater()
        {
            if (dispenserType == "basic water dispenser")
            {
                Console.WriteLine("Here's some lukewarm water!");
            }
            else if (dispenserType == "deluxe dispenser")
            {
                Console.WriteLine("Enjoy your perfect ice water.");
            }
            else
            {
                Console.WriteLine("What's gonna come out? It's a surprise!");
            }
        }
        public string ChangeBulbs()
        {
            if (bulbsWork == false)
            {
                bulbsWork = true;
                return "The bulbs have been changed";
            }
            else
            {
                return "The bulbs don't have to be changed";
            }
        }
        public void RemoveFood(int foodRemoved)
        {
            foodAmount -= foodRemoved;
        }
        public string CheckSupplies()
        {
            if (foodAmount >= 80)
            {
                return "fully stocked";
            }
            else if (foodAmount > 40)
            {
                return "getting low";
            }
            else
            {
                return "time to go grocery shopping";
            }
        }
        public string Clean()
        {
            if (isClean ==false)
            {
                isClean = true;
                return "I cleaned the fridge";
            }
            else
            {
                return "The fridge is already clean.";
            }

        }

    }
}
