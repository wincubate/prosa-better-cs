string filePath = @"C:\Tmp\deck.json";
string? s = null;

try
{
    s = await File.ReadAllTextAsync(filePath, CancellationToken.None);
}
catch (FileNotFoundException)
{
    Console.WriteLine("Sorry, mate. No such file!");
}

Console.WriteLine(s ?? string.Empty);