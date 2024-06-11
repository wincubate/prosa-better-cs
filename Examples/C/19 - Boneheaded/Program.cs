int[] numbers = [42, 87, 128, 176, 256];

try
{
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}
catch(IndexOutOfRangeException)
{
    // Wow! Near miss there, bro...! Saved your ass! :-)
}
