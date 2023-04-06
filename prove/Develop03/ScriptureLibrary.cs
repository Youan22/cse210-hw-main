// public class ScriptureLibrary
// {
//     private static readonly Dictionary<string, string> scriptures = new Dictionary<string, string>()
//     {
//         { "John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." },
//         { "Matthew 6:33", "But seek first his kingdom and his righteousness, and all these things will be given to you as well." },
//         { "Philippians 4:6-7", "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God. And the peace of God, which transcends all understanding, will guard your hearts and your minds in Christ Jesus." }
//         // Add more scriptures as desired
//     };

//     public static string GetScriptureText(string reference)
//     {
//         return scriptures[reference];
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Choose a scripture at random from the library
//         string[] references = new string[] { "John 3:16", "Matthew 6:33", "Philippians 4:6-7" };
//         string reference = references[new Random().Next(references.Length)];
//         string text = ScriptureLibrary.GetScriptureText(reference);

//         // Create a new scripture
//         Scripture scripture = new Scripture(reference, text);

//         // Display the scripture
//         Console.WriteLine(scripture.GetRenderedText());
//         Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");

//         // Hide words until the scripture is completely hidden
//         while (!scripture.IsCompletelyHidden())
//         {
//             string input = Console.ReadLine();
//             if (input == "quit")
//             {
//                 break;
//             }
//             scripture.HideWords();
//             Console.WriteLine(scripture.GetRenderedText());
//         }
//     }
// }

using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    private List<Scripture> scriptures;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();

        // Add some scriptures to the library

        scriptures.Add(new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture("Psalm 23:1", "The Lord is my shepherd; I shall not want."));
        scriptures.Add(new Scripture("Jeremiah 29:11", "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future."));
        scriptures.Add(new Scripture("Romans 8:28", "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."));
        scriptures.Add(new Scripture("Matthew 6:33", "But seek first his kingdom and his righteousness, and all these things will be given to you as well."));

    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}


