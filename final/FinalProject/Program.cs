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

                presiding.ConfirmAction(presiding._firstName, presiding._lastName, "Presiding");
            }
            else if(selectionDescription == "Assign Conducting"){
                List<string> bishopricTitles = meeting.getBishopricTitles();
                
                meeting.DisplayMenu(bishopricTitles);
                Console.Write("Which Bishopric member will be conducting? ");
                selection = Console.ReadLine();
                string title = meeting.GetSelectionDesc(bishopricTitles, selection);

                Conducting conducting = new Conducting(title);
                meeting.SetConducting(conducting);
                string name = conducting.getBishopricMember(title);
                
                Console.WriteLine($"{name} assigned to conduct the meeting.\n");
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
                
                speaker.ConfirmAction(speaker._firstName, speaker._lastName, "Speaker");
                
            }
            else if(selectionDescription == "Add Hymn"){
                List<string> hymnOrder = meeting.getHymnOrder();
                meeting.DisplayMenu(hymnOrder);

                Console.Write("Which hymn would you like to add? ");
                selection = Console.ReadLine();
                string order = meeting.GetSelectionDesc(hymnOrder, selection);

                Console.Write("What is the title of the hymn? ");
                string title = Console.ReadLine();

                Console.Write("What is the hymn number? ");
                int number = int.Parse(Console.ReadLine());

                Hymn hymn = new Hymn(order, title, number);
                meeting.AddHymn(hymn);

                Console.WriteLine($"{order} hymn is added: {number} - {title}.\n");
            }
            else if(selectionDescription == "Assign Prayer"){
                List<string> prayerOrder = meeting.getPrayerOrder();
                
                meeting.DisplayMenu(prayerOrder);
                Console.Write("Which prayer would you like to assign? ");
                selection = Console.ReadLine();
                string order = meeting.GetSelectionDesc(prayerOrder, selection);

                Console.Write("What is the members first name? ");
                string firstName = Console.ReadLine();

                Console.Write("What is the members last name? ");
                string lastName = Console.ReadLine();

                Prayer prayer = new Prayer(firstName, lastName, order);
                meeting.AddPrayer(prayer);
                
                prayer.ConfirmAction(prayer._firstName, prayer._lastName, order);
                
            }
            else if(selectionDescription == "Display Program"){
                meeting.DisplayMeetingInfo();
            }
            
            
        }
        
    }
}