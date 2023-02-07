using System;
using System.IO;

namespace CaptainJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string journalContent = "";
            Console.WriteLine("Enter 'start' to start writing the journal or 'stop' to exit: ");
            input = Console.ReadLine();
          
                while (input != "start")
            {
                Console.WriteLine("Enter 'start' to start writing the journal or 'stop' to exit: ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Enter journal entries. Enter 'stop' to stop writing: ");

            while (input != "stop")
            {
                input = Console.ReadLine();
                if (input != "stop")
                {
                    journalContent += input + "\n";
                }
            }

            string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            File.WriteAllText(fileName, "Captain's log\nStart date: " + DateTime.Now.ToString("yyyy-MM-dd") + "\n" + journalContent + "Jean-Luc Picard");
            Console.WriteLine("Journal saved as " + fileName);
        }
    }
}