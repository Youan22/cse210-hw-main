using System.Collections.Generic;
using System.IO;
class Journal
    {
        private List<Entry> entries = new List<Entry>();
        private List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        private Random random = new Random();

        public void WriteNewEntry()
        {
            Console.Clear();
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            Entry newEntry = new Entry(prompt, response, DateTime.Now.ToString("MM/dd/yyyy"));
            entries.Add(newEntry);
        }

        public void DisplayJournal()
        {
            Console.Clear();
            if (entries.Count == 0)
            {
                Console.WriteLine("Your journal is empty.");
            }
            else
            {
                foreach (Entry entry in entries)
                {
                    Console.WriteLine(entry.ToString());
                }
            }
        }

        public void SaveJournal()
        {
            Console.Clear();
            Console.WriteLine("Please enter a filename to save your journal to (include file extension):");
            string filename = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ToCSVString());
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }

        public void LoadJournal()
        {
            Console.Clear();
            Console.WriteLine("Please enter a filename to load your journal from (include file extension):");
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                entries.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] entryData = reader.ReadLine().Split('|');
                        Entry newEntry = new Entry(entryData[0], entryData[1], entryData[2]);
                        entries.Add(newEntry);
                    }
                }
                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }