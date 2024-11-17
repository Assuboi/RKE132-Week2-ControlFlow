// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema pereekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string(sõne) formaadis
Console.WriteLine("Pleas, enter your last name:");
string userLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}   
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}!");
}