// See https://aka.ms/new-console-template for more information
// Creating and RSVP

string [] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string [] rsvps = new string [10];
int count = 0;


RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", false);
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVP();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true){
    
    if(inviteOnly)
    {
        bool found = false;
            foreach (string guest in guestList)
            {
                if (guest.Equals(name)) {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Sorry, {name} is not on the guest list");
                return;
            }
    }
    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {Allergies}";
}

void ShowRSVP()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}