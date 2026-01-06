Console.WriteLine("What is your favorite flavor of ice cream?");
string? flavor = Console.ReadLine();

if (flavor == null)
{
    flavor = "vanilla";
}
if(flavor == "vanilla")
{
    Console.WriteLine("You're basic");
}
if(flavor == "strawberry")
{
    Console.WriteLine("That's fruity");
}
Console.WriteLine($"Your favorite flavor of ice cream is {flavor}");