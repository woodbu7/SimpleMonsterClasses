using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        /// <summary>
        /// get new ghost from user
        /// </summary>
        /// <param name="ghosts"></param>
        static void DisplayGetUserGhost(List<Ghost> ghosts)
        {
            Ghost ghost = new Ghost();

            Console.Write("Enter Name: ");
            ghost.Name = Console.ReadLine();

            Console.Write("Enter Number of Eyes: ");
            ghost.NumberOfEyers = int.Parse(Console.ReadLine());

            Console.Write("Is Visible: ");
            ghost.IsVisible = bool.Parse(Console.ReadLine());

            Console.Write("Is Dangerous: ");
            ghost.IsDangerous = bool.Parse(Console.ReadLine());

            ghosts.Add(ghost);
        }

        /// <summary>
        /// initialize the ghost fred
        /// </summary>
        /// <param name="fred"></param>
        static void InitializeGhostFred(Ghost fred)
        {
            fred.Name = "Fred";
            fred.NumberOfEyers = 8;
            fred.IsVisible = true;
            fred.IsDangerous = false;
            fred.TimeOfDeath = new DateTime(1900, 1, 16);
        }

        /// <summary>
        /// display info for all ghosts
        /// </summary>
        /// <param name="ghost"></param>
        static void DisplayGhostInfo(Ghost ghost)
        {
            Console.WriteLine($"{ghost.Name} has {ghost.NumberOfEyers} eyes.");
            if (ghost.IsVisible)
            {
                Console.WriteLine($"{ghost.Name} is visible.");
            }
            else
            {
                Console.WriteLine($"{ghost.Name} is invisible.");
            }

            if (ghost.IsDangerous)
            {
                Console.WriteLine($"{ghost.Name} is dangerous.");
            }
            else
            {
                Console.WriteLine($"{ghost.Name} is not dangerous.");
            }
            Console.WriteLine($"{ghost.Name} died on {ghost.TimeOfDeath}");
        }

        /// <summary>
        /// loops thorugh ghosts to display info
        /// </summary>
        /// <param name="ghosts"></param>
        static void DisplayAllGhost(List<Ghost> ghosts)
        {
            DisplayHeader("List All Ghosts");

            foreach (Ghost ghost in ghosts)
            {
                DisplayGhostInfo(ghost);
                Console.WriteLine();
            }
            //DisplaySeaMonsterInfo(seaMonster);

            DisplayContinuePrompt();
        }

        /// <summary>
        /// prompt the user for a sea monster
        /// </summary>
        /// <param name="seaMonsters"></param>
        static void DisplayGetUserSeaMonster(List<SeaMonster> seaMonsters)
        {
            SeaMonster seaMonster = new SeaMonster();

            Console.Write("Enter Name: ");
            seaMonster.Name = Console.ReadLine();
            // string name = Console.ReadLine();

            Console.Write("Enter Color: ");
            seaMonster.Color = Console.ReadLine();
            // string color = Console.ReadLine();

            // SeaMonster seaMonster = new SeaMonster(name, color);

            Console.Write("Enter Length in Meters: ");
            seaMonster.Size = int.Parse(Console.ReadLine());

            Console.Write("Lives in Salt Water: ");
            seaMonster.LivesInSaltWater = bool.Parse(Console.ReadLine());

            seaMonsters.Add(seaMonster);
        }

        /// <summary>
        /// initialize Sid 
        /// </summary>
        /// <param name="sid"></param>
        static void InitializeSeaMonsterSid(SeaMonster sid)
        {
            sid.Name = "Sid";
            sid.Color = "Blue";
            sid.Size = 32;
            sid.LivesInSaltWater = true;
            sid.Birthdate = new DateTime(456, 6, 9);
            sid.Emotion = SeaMonster.EmotionalState.SAD;
        }

        /// <summary>
        /// initilaize Suzy 
        /// </summary>
        /// <param name="sid"></param>
        static void InitializeSeaMonsterSuzy(SeaMonster suzy)
        {
            suzy.Name = "Suzy";
            suzy.Color = "Yellow";
            suzy.Size = 15;
            suzy.LivesInSaltWater = false;
            suzy.Birthdate = new DateTime(1990, 5, 15);
            suzy.Emotion = SeaMonster.EmotionalState.HAPPY;
        }


        /// <summary>
        /// display sea monster info
        /// </summary>
        /// <param name="seaMonster"></param>
        static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
        {
            Console.WriteLine($"{seaMonster.Name} is {seaMonster.Color}.");
            Console.WriteLine($"{seaMonster.Name} is {seaMonster.Size} meters long.");
            if (seaMonster.LivesInSaltWater)
            {
                Console.WriteLine($"{seaMonster.Name} lives in salt water.");
            }
            else
            {
                Console.WriteLine($"{seaMonster.Name} lives in fresh water.");
            }
            Console.WriteLine($"{seaMonster.Name}'s birthdate is {seaMonster.Birthdate}.");
            Console.WriteLine($"{seaMonster.Name} is a {seaMonster.Emotion.ToString().ToLower()} sea monster.");
            Console.WriteLine();
            Console.WriteLine($"{seaMonster.Name} says: \"{seaMonster.Greeting()}\"");
        }

        /// <summary>
        /// display all sea monsters
        /// </summary>
        static void DisplayAllSeaMonsters(List<SeaMonster> seaMonsters)
        {
            DisplayHeader("List All Sea Monsters");

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                DisplaySeaMonsterInfo(seaMonster);
                Console.WriteLine();
            }
            //DisplaySeaMonsterInfo(seaMonster);

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display menu
        /// </summary>
        static void DisplayMenu()
        {
            //
            // instantiate sea monsters
            //
            SeaMonster sid = new SeaMonster();
            InitializeSeaMonsterSid(sid);

            SeaMonster suzy = new SeaMonster();
            InitializeSeaMonsterSuzy(suzy);

            //
            // add sea monsters to list
            //
            List<SeaMonster> seaMonsters = new List<SeaMonster>();
            seaMonsters.Add(sid);
            seaMonsters.Add(suzy);

            //
            // instantiate ghosts
            //
            Ghost fred = new Ghost();
            InitializeGhostFred(fred);

            //
            // instantiate and create ghost list
            //
            List<Ghost> ghosts = new List<Ghost>();
            ghosts.Add(fred);

            //
            // local variables
            //
            bool exiting = false;
            int menuChoice = 0;

            //
            // The menu will loop until the user chooses to exit
            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine();
                Console.WriteLine("\t1) Enter New Sea Monster");
                Console.WriteLine("\t2) Display All Sea Monsters");
                Console.WriteLine("\t3) Enter New Ghost");
                Console.WriteLine("\t4) Display All Ghosts");
                Console.WriteLine("\t5) Exit");
                Console.WriteLine();
                Console.Write("Enter your menu choice:");

                //
                // validate user's response and parse to int menuChoice
                while (!int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    Console.WriteLine("Please enter the corresponding number for your menu choice:");
                    Console.ReadLine();
                }

                //
                // The switch statement calls the method based on menuChoice
                switch (menuChoice)
                {
                    case 1:
                        DisplayGetUserSeaMonster(seaMonsters);
                        break;

                    case 2:
                        DisplayAllSeaMonsters(seaMonsters);
                        break;

                    case 3:
                        DisplayGetUserGhost(ghosts);
                        break;

                    case 4:
                        DisplayAllGhost(ghosts);
                        break;

                    case 5:
                        exiting = true;
                        break;

                    default:
                        break;
                }
            }

            
        }


        /// <summary>
        /// display welcome screen
        /// </summary>
        private static void DisplayWelcomeScreen()
        {
            DisplayHeader("Welcome to My Application!");

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        private static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        private static void DisplayClosingScreen()
        {
            DisplayHeader("Thank you for using My Application");

            DisplayContinuePrompt();
        }
    }
}
