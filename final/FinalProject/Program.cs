using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Meeting meeting = new Meeting();
        List<string> menuChoices = meeting.getMenuChoices();

        string selection = "";

        while(selection != "7"){
            meeting.DisplayMenu(menuChoices);
            Console.Write("What would you like to do? ");
            selection = Console.ReadLine();

            string selectionDescription = meeting.GetSelectionDesc(menuChoices, selection);

            if(selectionDescription == "Assign Presiding"){
                Console.Write("What is the members first name? ");
                string firstName = Console.ReadLine();

                Console.Write("What is the members last name? ");
                string lastName = Console.ReadLine();

                // If selection is presiding
                Console.Write("What is the title of the presiding member's calling? ");
                string title = Console.ReadLine();

                Presiding presiding = new Presiding(firstName, lastName, title);
                meeting.SetPresiding(presiding);
            }
            else if(selectionDescription == "Assign Conducting"){
                List<string> bishopricTitles = meeting.getBishopricTitles();
                
                meeting.DisplayMenu(bishopricTitles);
                Console.Write("Which Bishopric member will be conducting? ");
                selection = Console.ReadLine();
                string title = meeting.GetSelectionDesc(bishopricTitles, selection);

                Conducting conducting = new Conducting(title);
                meeting.SetConducting(conducting);
                
            }
            else if(selectionDescription == "Display Program"){
                meeting.DisplayMeetingInfo();
            }
            
            
        }
        
    }
}