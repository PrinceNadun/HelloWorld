// A simple welcome app.
// Run with arguments:   dotnet run -- Alice 25
// Or run with no arguments and it will ask you for your name and age.
// When it's done, press any key to close the app.

string name;
int age;

if (args.Length >= 2)
{
    // Use the values passed on the command line.
    name = args[0];

    if (!int.TryParse(args[1], out age) || age < 0)
    {
        Console.WriteLine($"'{args[1]}' is not a valid age. Please enter a whole number.");
        return;
    }
}
else
{
    // No arguments given, so ask the user.
    Console.Write("What is your name? ");
    name = Console.ReadLine() ?? "";

    Console.Write("How old are you? ");
    while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
    {
        Console.Write("Please enter a valid age (a whole number): ");
    }
}

if (string.IsNullOrWhiteSpace(name))
{
    name = "guest";
}

Console.WriteLine(GetWelcomeMessage(name, age));
Console.WriteLine(GetAgeMessage(age));
Console.WriteLine("Thanks for visiting. Have a great day!");

// Builds the welcome message for a user.
static string GetWelcomeMessage(string name, int age)
{
    return $"Hi there, {name}! Welcome to Nexus Academy. You are {age} years old.";
}

// Gives a short message based on the user's age.
static string GetAgeMessage(int age)
{
    if (age < 13)
    {
        return "You're a young learner. Have fun coding!";
    }
    else if (age < 27)
    {
        return "Great time to start your coding journey!";
    }
    else
    {
        return "It's never too late to learn something new!";
    }
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();