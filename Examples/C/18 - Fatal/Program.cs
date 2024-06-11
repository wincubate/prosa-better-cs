string filePath = @"C:\Tmp\query.log";
string? s;

try
{
    s = await File.ReadAllTextAsync(filePath, CancellationToken.None);
}
catch(OutOfMemoryException)
{
    s = "Oops! Out of memory... Try again Y/N?";
}

Console.WriteLine(s);