/* **************************************************************** */
/*                        COC001 - ASSIGNMENT 2                     */
/* **************************************************************** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static List<Bike> Bikes = new List<Bike>();
        static void Main(string[] args)
        {
           
            getInventory(); //call the method to get the bikes from the inventory file
            
            displayBikes(); //display the inventory (Bikes list) to the screen
            menu();//displays menu

            Console.ReadLine(); //incase menu fails
        }

        static void menu()//menu
        {
            //main menu
            Console.WriteLine("===================");
            Console.WriteLine("Bike Porgram menu");
            Console.WriteLine("===================");
            Console.WriteLine("Please select a option");
            Console.WriteLine("Add");
            Console.WriteLine("Delete");
            Console.WriteLine("Edit");

            string Useroption; //user input
            Useroption = Console.ReadLine();
            Useroption = Useroption.ToLower();

            if (Useroption == "edit") //user editing bike data
            {
                Console.WriteLine("Which bike number do you wish to edit?");
                int numEntered; //assings vaule to edit bike number
                numEntered = int.Parse(Console.ReadLine());

                Console.WriteLine("What do you want to change?");
                Console.WriteLine("options to change: model, type, make, year, wheel size, forks");
                Console.WriteLine("or type 'exit' to exit edit mode");
                string CustomOpt;
                CustomOpt = Console.ReadLine();
                CustomOpt = CustomOpt.ToLower();
                //user options to change: model, type, make, year, wheel size, forks

                if (CustomOpt == "model") //user editing model data
                {
                    Console.WriteLine(Bikes[numEntered].Model); //finds number entered from bike list
                    Console.WriteLine("Your editing bike {0} model", numEntered);
                    Console.WriteLine("Please enter the new model");

                    string CustomModel;

                    CustomModel = Console.ReadLine();
                    Bikes[numEntered].Model = CustomModel; //finds and replaces
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Changed model to {0}", CustomModel);
                    Console.ForegroundColor = ConsoleColor.White;
                    displayBikes();
                    menu();
                }

                if (CustomOpt == "type") //user editing bike type
                {
                    Console.WriteLine(Bikes[numEntered].Type);
                    Console.WriteLine("Your editing bike {0} type", numEntered);
                    Console.WriteLine("Please enter the new type");

                    string CustomType;

                    CustomType = Console.ReadLine();
                    Bikes[numEntered].Type = CustomType;//finds and replaces
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Changed Type to {0}", CustomType);
                    Console.ForegroundColor = ConsoleColor.White;
                    displayBikes();
                    menu();
                }

                if (CustomOpt == "make") //editing bike make info
                {
                    Console.WriteLine(Bikes[numEntered].Make);
                    Console.WriteLine("Your editing bike {0} make", numEntered);
                    Console.WriteLine("Please enter the new name");

                    string CustomMake;

                    CustomMake = Console.ReadLine();
                    Bikes[numEntered].Make = CustomMake;//finds and replaces
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Changed make to {0}", CustomMake);
                    Console.ForegroundColor = ConsoleColor.White;
                    displayBikes();
                    menu();
                }

                if (CustomOpt == "year") //bike year info
                {
                    Console.WriteLine(Bikes[numEntered].Year);
                    Console.WriteLine("Your editing bike {0} Year", numEntered);
                    Console.WriteLine("Please enter the new Year");

                    int CustomYear;

                    CustomYear = int.Parse(Console.ReadLine());
                    Bikes[numEntered].Year = CustomYear;//finds and replaces
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Changed year to {0}", CustomYear);
                    Console.ForegroundColor = ConsoleColor.White;
                    displayBikes();
                    menu();
                }

                if (CustomOpt == "wheel size") //wheel info edit
                {
                    Console.WriteLine(Bikes[numEntered].WheelSize);
                    Console.WriteLine("Your editing bike {0} wheel size", numEntered);
                    Console.WriteLine("Please enter the new wheel size");

                    string CustomSize;

                    CustomSize = Console.ReadLine();
                    Bikes[numEntered].WheelSize = CustomSize;//finds and replaces
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Changed wheel size to {0}", CustomSize);
                    Console.ForegroundColor = ConsoleColor.White;
                    displayBikes();
                    menu();
                }

                if (CustomOpt == "forks") //fork info
                {
                    Console.WriteLine("Current fork:");
                    Console.WriteLine(Bikes[numEntered].Forks);
                    Console.WriteLine("Your editing bike {0} forks", numEntered);
                    Console.WriteLine("Please enter the new forks");

                    string CustomForks;

                    CustomForks = Console.ReadLine();
                    Bikes[numEntered].Forks = CustomForks;//finds and replaces
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Changed forks to {0}", CustomForks);
                    Console.ForegroundColor = ConsoleColor.White;
                    displayBikes();
                    menu();
                }

                if(CustomOpt == "exit") //Validate user input 
                {
                    menu();
                }

                else //Validate user input 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid command");
                    Console.ForegroundColor = ConsoleColor.White;
                    menu();
                }
            }

            if (Useroption == "delete") //delete bike option from inventory
            {
                Console.WriteLine("Which bike number do you wish to delete?");
                int numEntered; //assings vaule to edit bike number
                numEntered = int.Parse(Console.ReadLine());
                Console.WriteLine("Do you wish to delete bike {0}? (yes/no)",numEntered);
                string UserDelOpt; //user input for deletion
                UserDelOpt = Console.ReadLine();

                if (UserDelOpt =="yes") //deletes bike user selected 
                {
                    
                    Bikes.RemoveAt(numEntered);
                    Bike.bikeCount--; //removes bike from count

                    Console.WriteLine("Removed Bike");
                    displayBikes(); //display the inventory (Bikes list) to the screen
                    menu();
                }
                if (UserDelOpt=="no") //cancels deletion 
                {
                    Console.WriteLine("Deletion aborted");
                    menu();
                }
                else //user vaildation (cancels deletion)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid command");
                    Console.ForegroundColor = ConsoleColor.White;
                    menu();
                }
            }

            if(Useroption =="add") //add bike to the inventory
            {
                //User Input vars
                string UserMake;
                string UserType;
                string UserModel;
                //test var int UserYear;
                string UserWheel;
                string UserFrame;
                //test var int UserCode;

                Console.Clear(); //clears console to make things cleaner as users add new bike
                Console.ForegroundColor = ConsoleColor.Cyan; //changes colours 
                Console.WriteLine("Adding new bike...");
                Console.ForegroundColor = ConsoleColor.White;

                //bike make
                Console.WriteLine("Please input the Make of the bike");
                UserMake = Console.ReadLine(); //reads then assings 
                string make = UserMake; //store the make

                //bike model
                Console.WriteLine("Please input the Type of bike");
                UserType = Console.ReadLine();//reads then assings
                string type = UserType; //store the type

                //bike model
                Console.WriteLine("Please input the model of bike");
                UserModel = Console.ReadLine();//reads then assings
                string model = UserModel; //store the model

                //bike year
                Console.WriteLine("Please input the bike year");
                //Test code UserYear = int.Parse(Console.ReadLine()); //reads then assings
                int year = int.Parse(Console.ReadLine());//store the year

                //Wheel size
                Console.WriteLine("Please input the wheel size");
                UserWheel = Console.ReadLine();//reads then assings
                string wheelSize = UserWheel; //store the wheel size

                //Frame
                Console.WriteLine("Please input the Frame size");
                UserFrame = Console.ReadLine();//reads then assings
                string frameType = UserFrame; //store the frame type

                //SecCode
                Console.WriteLine("Please input the bike Security Code");
                //Test code UserCode = int.Parse(Console.ReadLine()); //reads then assings
                int securityCode = int.Parse(Console.ReadLine()); //store the security code

                Bike bk = new Bike(make, type, model, year, wheelSize, frameType, securityCode); //create a new bike object with the details stored above

                Bikes.Add(bk); //add the bike to Bikes list

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Added new bike!");
                Console.ForegroundColor = ConsoleColor.White;
                displayBikes(); //display the inventory (Bikes list) to the screen
                menu(); //exits to menu

            }

            


            //Validate user input 
            else//restarts menu 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid command");
                Console.ForegroundColor = ConsoleColor.White;
                menu();
            }
        }


        static void getInventory() //method to get the bikes from the inventory file
        {
            //read the file into a text string
            string[] lines = System.IO.File.ReadAllLines(@"inventory.txt");

            int invCounter = 0;

            int invLength = lines.Length / 8; //works out the number of bikes in the inventory.txt file

            for (int i = 0; i <= invLength; i++) //for each bike
            {
                string make = lines[i + invCounter++]; //store the make
                string type = lines[i + invCounter++]; //store the type
                string model = lines[i + invCounter++]; //store the model
                int year = int.Parse(lines[i + invCounter++]); //store the year
                string wheelSize = lines[i + invCounter++]; //store the wheel size
                string frameType = lines[i + invCounter++]; //store the frame type
                int securityCode = int.Parse(lines[i + invCounter++]); //store the security code

                Bike bk = new Bike(make, type, model, year, wheelSize, frameType, securityCode); //create a new bike object with the details stored above

                Bikes.Add(bk); //add the bike to Bikes list
            }
        }
        static void displayBikes() //display the inventory (Bikes list) to the screen
        {
            //adds number to bike to count
            int counter = 0;

            //inventory header
            //This is a mess of code and probs could be done better but this is what i came up with (it works somehow?!)
            //Write line pulls header name from strings and outputs to create the header.

            string a = "Number";
            string b = "Bike Type";
            string c = "Code";
            string d = "Make & Model";
            string e = "Year";
            string f = "Wheel Size";
            string g = "Forks";

            //header output
            Console.WriteLine("{1,-10}\t {2,-10}\t {3,-10}\t {4,-20}\t {5,-5}\t {6,-10}\t {7}", counter, a, b, c, d, e, f, g);
            

            foreach (Bike bk in Bikes)
            {
                //Console.WriteLine("{1,-10}\t {2,-10}\t {3,-10}\t {4,-20}\t {5,-5}\t {6,-10}\t {7}", counter, a, b, c, d, e, f, g); test code
                Console.WriteLine("{0,-10}\t {1,-10}\t {2,-10}\t {3,-10}\t {4,-5}\t {5,-5}\t {6}\t {7}",counter, bk.Type, bk.SecurityCode, bk.Make, bk.Model, bk.Year, bk.WheelSize, bk.Forks);
                counter++;
            }


            //bike total output
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.Cyan; //gives colour to stand out
            Console.WriteLine("Total number of bikes in inventory: {0}", Bike.bikeCount); //reads from bike class
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("========================================");

        } 
    }
}
