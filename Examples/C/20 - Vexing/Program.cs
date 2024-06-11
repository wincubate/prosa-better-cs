bool isInputEnteredCorrectly = false;
while (!isInputEnteredCorrectly)
{
    try
    {
        Console.WriteLine("Enter temperature: ");
        string? input = Console.ReadLine() ?? "0";
        int temperature = int.Parse(input);

        string temperatureLine = $"The temperature is {temperature switch
        {
            <= 0 => "Freezing...",
            < 12 => "Autumn-like",
            <= 19 => "Spring-ish",
            <= 40 => "Summer!",
            _ => "Death Valley?"
        }}";
        Console.WriteLine(temperatureLine);

        isInputEnteredCorrectly = true;
    }
    catch (FormatException)
    {
    }
}