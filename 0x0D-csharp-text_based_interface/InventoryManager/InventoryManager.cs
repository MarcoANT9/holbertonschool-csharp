using System;
using System.Collections.Generic;
using System.Reflection;
//using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //JSON Storage Engine Start
            JSONStorage storageDevice = new JSONStorage();
            storageDevice.Load();

            //List of all classes
            List<string> classList = new List<string>
            {
                "item",
                "user",
                "inventory"
            };

            //List of all Commands
            List<string> commandList = new List<string>
            {
                "classnames",
                "all",
                "create",
                "show",
                "update",
                "delete",
                "exit"
            };

            // //Response to unkown commands
            // string[] commandUnknown = new string[]
            // {
            //     "I'm sorry Dave, I'm afraid I can't do that...",
            //     "This command can serve no purpose anymore.",
            //     "I sincerely hope you weren't expecting a response.",
            //     "Stop it, you're going to brake it",
            //     "01001110 01101111",
            //     "Nope.avi",
            //     "Input a valid command, you have 20 seconds to comply",
            //     "... what now?",
            // };

            // Exit responses
            // string[] exitApp = new string[]
            // {
            //     "I'll be back",
            //     "Hasta la vista",
            //     "Thank you for helping us help you help us all",
            //     "Sleep mode activated",
            //     "It as a pleasure meeting you, now I'll go end my life",
            //     "System shotdown... BOOM"
            // };

            //Prompt Configuration
            string prompt = "$ ";

            Random randomNumber = new Random();
            string[] promptList = new string[]{
                "(° ~°)> ", "(* ~*)> ",
                "(° -°)> ", "(° .°)> ",
                "(` _´)> ", "(O _o)> ",
                "(n _n)> ", "(u _u)> ",
                "(ò _ó)> ", "(¬ _¬)> ",
                "(* -*)> ", "(⌐■_■)> "
            };
            Dictionary<string, ConsoleColor> colorlist = new Dictionary<string, ConsoleColor>();
            colorlist.Add("(° ~°)> ", ConsoleColor.Blue);
            colorlist.Add("(* ~*)> ", ConsoleColor.DarkBlue);
            colorlist.Add("(° -°)> ", ConsoleColor.Yellow);
            colorlist.Add("(° .°)> ", ConsoleColor.DarkYellow);
            colorlist.Add("(` _´)> ", ConsoleColor.Magenta);
            colorlist.Add("(O _o)> ", ConsoleColor.DarkMagenta);
            colorlist.Add("(n _n)> ", ConsoleColor.Green);
            colorlist.Add("(u _u)> ", ConsoleColor.DarkGreen);
            colorlist.Add("(ò _ó)> ", ConsoleColor.Red);
            colorlist.Add("(¬ _¬)> ", ConsoleColor.DarkRed);
            colorlist.Add("(* -*)> ", ConsoleColor.Cyan);
            colorlist.Add("(⌐■_■)> ", ConsoleColor.DarkCyan);

            //User input parser
            string[] userSplit;

            //Console App
            while (true)
            {
                //Display Command list (with Colors!)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Inventory Manager");
                Console.WriteLine("-------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("<ClassNames> show all ClassNames of objects");
                Console.WriteLine("<All> show all objects");
                Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
                Console.WriteLine("<Create [ClassName]> a new object");
                Console.WriteLine("<Show [ClassName object_id]> an object");
                Console.WriteLine("<Update [ClassName object_id]> an object");
                Console.WriteLine("<Delete [ClassName object_id]> an object");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("<Exit>");
                //End of Command List Display

                //Choose random string and color for prompt
                int randomConsole = randomNumber.Next(0, promptList.Length);
                prompt = promptList[randomConsole];
                Console.ForegroundColor = colorlist[prompt];
                Console.Write(prompt);

                //Split and turn to lowercase user input
                userSplit = Console.ReadLine().Split(' ');

                //~ "METHODS" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                switch (userSplit[0].ToLower())
                {
                    /// <summary>
                    /// Displays all available classes.
                    /// </summary>
                    case "classnames":
                        {
                            foreach (string classes in classList)
                                Console.WriteLine($"{classes}");
                            continue;
                        }

                    /// <summary>
                    /// Displays all elements.
                    /// </summary>
                    /// <param name="ClassName">Optional: show only objects with this Class.</param>
                    case "all":
                        {
                            //Display all elements of a given ClassName.
                            try
                            {
                                if (userSplit[1].ToLower() != null)
                                {
                                    if (classList.Contains(userSplit[1].ToLower()))
                                    {
                                        foreach (KeyValuePair<string, object> kvp in storageDevice.objects)
                                        {
                                            if (kvp.Key.Split('.')[0] == userSplit[1].ToLower())
                                            {
                                                Console.WriteLine(kvp.Value);
                                                Console.WriteLine("-------");
                                            }
                                        }
                                    }
                                    else
                                        Console.WriteLine($"{userSplit[1]} is not a valid object type");
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                //Display all elements in the Objects dictionary.
                                foreach (KeyValuePair<string, object> kvp in storageDevice.objects)
                                {
                                    Console.WriteLine(kvp.Value);
                                    Console.WriteLine("-------");
                                }

                            }
                            continue;
                        }

                    /// <summary>
                    /// Creates a new object.
                    /// </summary>
                    /// <param name="ClassName">Object Class.</param>
                    case "create":
                        {
                            if (userSplit.Length < 2)
                            {
                                Console.WriteLine("Object ClassName is missing");
                                continue;
                            }
                            else
                            {
                                try
                                {
                                    if (classList.Contains(userSplit[1].ToLower()))
                                    {
                                        storageDevice.New(userSplit[1].ToLower());
                                        Console.WriteLine($"Object of the class {userSplit[1]} has been created");
                                        storageDevice.Save();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{userSplit[1]} is not a valid object type");
                                        continue;
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    Console.WriteLine("Usage: Create <ClassName>");
                                    continue;
                                }
                            }
                            continue;
                        }

                    /// <summary>
                    /// Shows an existing object.
                    /// </summary>
                    /// <param name="ClassName">Object Class.</param>
                    /// <param name="Id">Object Id.</param>
                    case "show":
                        {
                            if (userSplit.Length == 2)
                            {
                                Console.WriteLine("Id is missing");
                                continue;
                            }
                            else if (userSplit.Length == 1)
                            {
                                Console.WriteLine("ClassName is missing");
                                continue;
                            }
                            else
                            {
                                if (classList.Contains(userSplit[1].ToLower()))
                                {
                                    bool found = false;
                                    foreach (KeyValuePair<string, object> kvp in storageDevice.objects)
                                    {
                                        if (kvp.Key.Split('.')[0] == userSplit[1].ToLower() && kvp.Key.Split('.')[1] == userSplit[2])
                                        {
                                            Console.WriteLine(storageDevice.objects[kvp.Key]);
                                            found = true;
                                            break;
                                        }
                                    }
                                    if (found == false)
                                        Console.WriteLine($"Object {userSplit[2]} could not be found");
                                }
                                else
                                    Console.WriteLine($"{userSplit[1]} is not a valid object type");
                            }
                            continue;
                        }

                    /// <summary>
                    /// Updates an existing object.
                    /// </summary>
                    /// <param name="ClassName">Object Class.</param>
                    /// <param name="Id">Object Id.</param>
                    case "update":
                        {
                            if (userSplit.Length == 2)
                            {
                                Console.WriteLine("Id is missing");
                                continue;
                            }
                            else if (userSplit.Length == 1)
                            {
                                Console.WriteLine("ClassName is missing");
                                continue;
                            }
                            continue;
                        }

                    /// <summary>
                    /// Deletes an existing object. Usage: Delete [ClassName] [Id]
                    /// </summary>
                    /// <param name="ClassName">Object Class.</param>
                    /// <param name="Id">Object Id.</param>
                    case "delete":
                        {
                            if (userSplit.Length == 2)
                            {
                                Console.WriteLine("Id is missing");
                                continue;
                            }
                            else if (userSplit.Length == 1)
                            {
                                Console.WriteLine("ClassName is missing");
                                continue;
                            }
                            else
                            {
                                if (classList.Contains(userSplit[1].ToLower()))
                                {
                                    bool found = false;
                                    foreach (KeyValuePair<string, object> kvp in storageDevice.objects)
                                    {
                                        if (kvp.Key.Split('.')[0] == userSplit[1].ToLower() && kvp.Key.Split('.')[1] == userSplit[2])
                                        {
                                            storageDevice.objects.Remove(kvp.Key);
                                            storageDevice.Save();
                                            found = true;
                                            break;
                                        }
                                    }
                                    if (found == false)
                                        Console.WriteLine($"Object {userSplit[2]} could not be found");
                                }
                                else
                                    Console.WriteLine($"{userSplit[1]} is not a valid object type");
                            }
                            continue;
                        }

                    /// <summary>
                    /// Terminatess the console.
                    /// </summary>
                    case "exit":
                        {
                            // int response = randomNumber.Next(0, exitApp.Length);
                            // Console.WriteLine(exitApp[response]);
                            Console.ForegroundColor = ConsoleColor.White;
                            return;
                        }

                    /// <summary>
                    /// For unknown commands
                    /// </summary>
                    default:
                        {
                            // int response = randomNumber.Next(0, commandUnknown.Length);
                            // Console.WriteLine(commandUnknown[response]);
                            Console.WriteLine("Command Unkown");
                            continue;
                        }
                }
            }
        }
    }
}