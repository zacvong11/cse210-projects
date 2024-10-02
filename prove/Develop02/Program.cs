using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        Prompt prompt = new Prompt();

        string choice = "";

        Console.WriteLine("\n\nWelcome to the journal program!");

        while(choice!= "5")
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1: Write");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Entries");
            Console.WriteLine("4. Load Saves");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            choice = Console.ReadLine();

            if(choice=="1")
            {
                string promptText = prompt.GetPrompt();
                Console.WriteLine($"Prompt: {promptText}");
                Console.WriteLine("Your Entry: ");
                string entryText = Console.ReadLine();
                string dateText = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(dateText, promptText, entryText);

                myJournal.AddEntry(newEntry);
            }

            else if(choice=="2")
            {
                myJournal.DisplayAll();
            }

            else if(choice=="3")
            {
                Console.WriteLine("Enter a filename to store your entries: ");
                string saveFileName = Console.ReadLine();
                myJournal.SaveToFile(saveFileName);
            }

            else if(choice=="4")
            {
                Console.WriteLine("Enter a filename to saves from: ");
                string loadFileName = Console.ReadLine();
                myJournal.LoadFromFile(loadFileName);
            }

            else if(choice=="5")
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
    

      
    //     {
    //         Entry newEntry = new Entry(DateTime.Now.ToString(), "What did you learn today?", "I learned how to save and load data in C#.");
    //         myJournal.AddEntry(newEntry);

    //         myJournal.SaveToFile("journal.txt");

    //         myJournal.LoadFromFile("journal.txt");

    //         myJournal.DisplayAll();
    //     {
    // }
// }