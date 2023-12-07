using PeopleDB;

/*
 * Opdracht: ga op zoek naar de comments die starten met TODO
 * en voeg daar de nodig code toe.
 * De opdrachten zitten in dit bestand, en in het bestand Group.cs
 */

Group group = new Group();
string filePath = "../../../database.json";

// try to load data
LoadFromDisk();

// Menu setup
Menu menu = new Menu();
menu.AddOption('1', "Set Group Name", SetGroupName);
menu.AddOption('2', "Add Person", AddPerson);
menu.AddOption('3', "Show Members", ShowMembers);

menu.Start();

// menu had ended. Save everything
SaveToDisk();


// Hier beginnen de opdrachten
void SetGroupName()
{
    // TODO: vraag om een groepsnaam en wijs die toe aan de groep
    Console.WriteLine("Geef een groepsnaam: ");
    group.Name = Console.ReadLine();
}

void AddPerson()
{
    Person person = new Person();

    // TODO: vraag naam, leeftijd, en hobbies en wijs die toe aan de persoon
    Console.WriteLine("Naam: ");
    person.Name = Console.ReadLine();
    Console.WriteLine("Leeftijd: ");
    person.Age = Console.Read();
    Console.WriteLine("Hobbies: ");
    for (int i = 0; i < person.Hobbys.Count + 1; i++)
    {
        string hobby = Console.ReadLine();
        person.Hobbys.Add(hobby);
        if (hobby == "")
        {
            person.Hobbys.Remove(hobby);
        }
    }
    group.People.Add(person);
}

void ShowMembers()
{
    // TODO: toon de naam van de groep, en info over alle leden
    
}

void SaveToDisk()
{
    // TODO: gebruik de variabele filePath (hierboven gedeclareerd) 
    // om een JSON versie van de groep op te slaan. Voeg foutafhandeling toe.
}

void LoadFromDisk()
{
    // TODO: gebruik de variabele filePath (hierboven gedeclareerd) 
    // om een JSON versie van de groep te laden. Voeg foutafhandeling toe.
}


