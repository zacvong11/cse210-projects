// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop03 World!");
//     }

//     Ref newRef = new Ref();
// }
using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        scriptureLibrary.AddScripture(new Ref("John", 3, 16), 
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        scriptureLibrary.AddScripture(new Ref("Proverbs", 3, 5, 6), 
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        scriptureLibrary.AddScripture(new Ref("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all \nmen that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong \nunto them.");

        scriptureLibrary.AddScripture(new Ref("Philippians", 4, 13), 
            "I can do all this through him who gives me strength.");

        Scripture scripture = scriptureLibrary.GetRandomScripture();

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.AreAllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("\nAll words are hidden. Memorization complete!");
                break;
            }
        }
    }
}
