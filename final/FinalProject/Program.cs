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
            else if(selectionDescription == "Add Speaker"){
                List<string> speakingOrder = meeting.getSpeakingOrder();
                
                meeting.DisplayMenu(speakingOrder);
                Console.Write("Which speaker would you like to add? ");
                selection = Console.ReadLine();
                string order = meeting.GetSelectionDesc(speakingOrder, selection);

                Console.Write("What is the members first name? ");
                string firstName = Console.ReadLine();

                Console.Write("What is the members last name? ");
                string lastName = Console.ReadLine();

                // If selection is presiding
                Console.Write("What is the topic for the speaker? ");
                string topic = Console.ReadLine();

                Speaker speaker = new Speaker(firstName, lastName, topic, order);
                meeting.AddSpeaker(speaker);
                // List<Speaker> speakers = speaker.GetSpeakers();

                // meeting.SetSpeakers(speakers);
                
                
            }
            else if(selectionDescription == "Display Program"){
                meeting.DisplayMeetingInfo();
            }
            
            
        }
        
    }
}