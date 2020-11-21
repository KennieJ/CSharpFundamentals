using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        // method that runs/starts the application
        public void Run()
        {
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content by Title\n" +
                    "4, Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                // Get the user's input
                string input = Console.ReadLine();

                //Evaluate the input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View content
                        DisplayAllContent();
                        break;
                    case "3":
                        //View content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //delete existing content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        }

        //Create new StreamingContent
        private void CreateNewContent()
        {

        }

        //View current StreamingContent that is saved
        private void DisplayAllContent()
        {
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content (5.8, 10, 1.5, etc.):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //Is family friendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();
            
            if(familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action\n");
            
            /*
                Horror = 1,
                RomCom,
                SciFi,
                Documentary,
                Bromance,
                Drama,
                Action 
             */

        }

        //View existing Content by title
        private void DisplayContentByTitle()
        {

        }

        //Update Existing content
        private void UpdateExistingContent()
        {

        }

        //Delete Existing Content
        private void DeleteExistingContent()
        {

        }
    }
}
