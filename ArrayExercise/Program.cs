// Task 1 - Simple Array Manipulation:
// Create a console application that asks the user to input 5 numbers. Store these numbers in an array.
// Then, the application should print out the numbers in reverse order, the smallest number, and the largest number.


bool runningProgram = true;

while (runningProgram)
{
    //Ett meddelande till användaren 
    Console.WriteLine("Välkommen, var god och följ anvisningarna och fyll i 5 olika numer efter varandra");

    int[] inputNumbersFromUser = GetAndPrintOutInputsFromTheUser();

    //Calling functions from ShowTheInputsReverse, ShowTheSmallaestInputNumber, ShowTheHighestInputNumber and EndProgram.
    ShowTheInputsReverse(inputNumbersFromUser);
    ShowTheSmallaestInputNumber(inputNumbersFromUser);
    ShowTheHighestInputNumber(inputNumbersFromUser);

    runningProgram = EndProgram(runningProgram);
}


//En funktion för att hämta all input och  VISAR all inmatning från användaren , GetAndPrintOutInputsFromTheUser() och returnerar en array av heltal, int[].
//Felhantering - konvertera inskrivningen från användaren till en int och lagrar den i arrayen, inputNumbersFromUser. (!int.TryParse(Console.ReadLine(), out inputNumbersFromUserkonvertera[])
//Om användaren skriver annat än siffror, visa ett meddelande annars fortsätt att följa processen.
//använder while-loop för att se till att användaren skriver in rätt värde annars kommer den att fortsätta att visa felmeddelandet tills användaren skriver in rätt värde.
static int[] GetAndPrintOutInputsFromTheUser()
{
    //skapar EN NY array för att spara användarens (5 st) input-inmatning. 
    int[] inputNumbersFromUser = new int[5];

    Console.Write("Skriv in ditt första nummer: ");
    while (!int.TryParse(Console.ReadLine(), out inputNumbersFromUser[0]))
    {
        Console.WriteLine("Ogiltig inmatning, var god och skriv en siffra");
        Console.Write("Skriv in ditt första nummer: ");
    }

    Console.Write("Skriv in ditt andra nummer: ");
    while (!int.TryParse(Console.ReadLine(), out inputNumbersFromUser[1]))
    {
        Console.WriteLine("Ogiltig inmatning, var god och skriv en siffra");
        Console.Write("Skriv in ditt andra nummer: ");
    }

    Console.Write("Skriv in ditt tredje nummer: ");
    while (!int.TryParse(Console.ReadLine(), out inputNumbersFromUser[2]))
    {
        Console.WriteLine("Ogiltig inmatning, var god och skriv en siffra");
        Console.Write("Skriv in ditt tredje nummer: ");
    }

    Console.Write("Skriv in ditt fjärde nummer: ");
    while (!int.TryParse(Console.ReadLine(), out inputNumbersFromUser[3]))
    {
        Console.WriteLine("Ogiltig inmatning, var god och skriv en siffra");
        Console.Write("Skriv in ditt fjärde nummer: ");
    }


    Console.Write("Skriv in ditt femte nummer: ");
    while (!int.TryParse(Console.ReadLine(), out inputNumbersFromUser[4]))
    {
        Console.WriteLine("Ogiltig inmatning, var god och skriv en siffra");
        Console.Write("Skriv in ditt femte nummer: ");
    }

    return inputNumbersFromUser;
}

//En funktion som hämtar en array, inputNumbersFromUser i prametern, och VISAR användarens inmatning i tvärtom ordning (REVERSE), ShowTheInputsReverse.
//Har använt utav en inbygd funktion, Reverse() och en forEach loop där vi går igenom arrayen, inputNumbersFromUsers. Och för varje *nummer* i inputNumbersFromUser skriv ut *number* till användaren.
static void ShowTheInputsReverse(int [] inputNumbersFromUser)
{ 
    Array.Reverse(inputNumbersFromUser);

    Console.WriteLine("Här nedan är dina angivna nummber i tvärtom ordning, alltså reverse!");

    foreach (int number in inputNumbersFromUser)
    { 
        Console.WriteLine(number); 
    }
}

//En funktion för att visa det lägsta nummret från användarens inmatning med inbbyggd funktion, Min() för att hämta de minsta värdet från arrayen.
static void ShowTheSmallaestInputNumber(int[] inputNumbersFromUser)
{
    int smallestNumber = inputNumbersFromUser.Min();

    Console.WriteLine($"Här är ditt lägsta nummer: {smallestNumber} ");

    //**Min första lösning! Har ändrat till en mer simpel lösning (se ovan).**
    //int smallestNumber = inputNumbersFromUser[0];

    //for ( int i = 0; i < inputNumbersFromUser.Length; i++ ) 
    //{
    //    if (inputNumbersFromUser[i] < smallestNumber)
    //    {
    //        smallestNumber = inputNumbersFromUser[i];
    //    }
    //}

    //    Console.WriteLine($"Här är ditt lägsta nummer: {smallestNumber}");
}

//En funktion för att visa det HÖGSTA nummret från användarens inmatning  med inbbyggd funktion, Max() för att hämta dey högsta värdet från arrayen.
static void ShowTheHighestInputNumber(int[] inputNumbersFromUser)
{
    int highestNumber = inputNumbersFromUser.Max();

    Console.WriteLine($"Här är ditt högsta nummer: {highestNumber}");
}

//En funktion för att avsluta programmet, om användaren skriver ja/JA så avbryts applikationen
static bool EndProgram(bool runningProgram)
{
    Console.WriteLine("Vill du avsulta applikationen ? ja/nej");
    string quitProgram = Console.ReadLine()!.ToLower();

    if (quitProgram == "ja")
    {
        runningProgram = false;
    }

    return runningProgram;
}