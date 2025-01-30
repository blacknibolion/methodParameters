// See https://aka.ms/new-console-template for more information
//Excercise challenge
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    DisplayEmail(external[i,0], external[i,1], externalDomain);
}
void DisplayEmail(string first, string last, string domain="hayworth.com")
{
    string email =first.Substring(0,2) + last.Substring(0,3) + "@" + domain;
    email = email.ToLower();
    Console.WriteLine(email);
}