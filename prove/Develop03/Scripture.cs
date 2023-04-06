using System;
using System.Collections.Generic;

public class Scripture
{
    public string Reference { get; }
    private List<Word> words;
    private Random random;
    private static Dictionary<string, string> scriptureLibrary = new Dictionary<string, string>
    {
        { "John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." },
        { "Matthew 6:33", "But seek first his kingdom and his righteousness, and all these things will be given to you as well." },
        { "Psalm 23:1", "The LORD is my shepherd, I lack nothing." },
        { "Romans 8:28", "And we know that in all things God works for the good of those who love him, who have been called according to his purpose." },
        {"Jeremiah 29:11", "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future."}
    };

    public Scripture(string reference, string text)
    {
        Reference = reference;
        words = new List<Word>();
        random = new Random();

        // Get text from library based on reference
        string scripture = scriptureLibrary[reference];

        // Split text into individual words
        string[] wordArray = text.Split(' ');

        // Add each word to the list of words
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public string GetRenderedText()
    {
        string renderedText = Reference + "\n\n";

        // Render each word, hiding some at random
        foreach (Word word in words)
        {
            if (word.IsHidden)
            {
                renderedText += "____ ";
            }
            else
            {
                renderedText += word.Text + " ";
            }
        }

        return renderedText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }

        return true;
    }

    public void HideWords()
    {
        // Choose a random number of words to hide
        int numWordsToHide = random.Next(1, words.Count / 2);

        // Choose random words to hide
        for (int i = 0; i < numWordsToHide; i++)
        {
            int randomIndex = random.Next(words.Count);
            words[randomIndex].Hide();
        }
    }
}
