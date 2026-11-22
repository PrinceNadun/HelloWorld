// A simple welcome app.
// Run with arguments:   dotnet run -- Alice 25
// Or run with no arguments and it will ask you for your name and age.

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
    name = "friend";
}

Console.WriteLine(GetWelcomeMessage(name, age));

// Builds the welcome message for a user.
static string GetWelcomeMessage(string name, int age)
{
    return $"Hello, {name}! Welcome aboard. You are {age} years old.";
}
