using System;

Album album1 = new Album("Depeche Mode", "Violator", new DateTime(1990, 03, 19));
Album album2 = new Album("Depeche Mode", "Violator", new DateTime(1990, 03, 19));
Console.WriteLine(album1);

Single single1 = new Single("Depeche Mode", "Enjoy the Silence", new DateTime(1990, 1, 1), album1);
Single single2 = new Single("Depeche Mode", "Enjoy the Silence", new DateTime(1990, 1, 1), album2);
Console.WriteLine(single1);

Console.WriteLine(single1 == single2);

abstract record Record(string Artist, string Name, DateTime? ReleaseDate = default)
{
    public int? Age
    {
        get
        {
            if (ReleaseDate.HasValue)
            {
                DateTime today = DateTime.Now;
                return today.Year - ReleaseDate.Value.Year - (ReleaseDate.Value.DayOfYear < today.DayOfYear ? 0 : 1);
            }

            return null;
        }
    }
}

sealed record Single(string Artist, string Name, DateTime? ReleaseDate, Album? Album)
    : Record(Artist, Name, ReleaseDate)
{
    public override string ToString() =>
        $"{Artist}: \"{Name}\" [{ReleaseDate}] - From the album \"{Album?.Name ?? ""}\"";
}

record Album(string Artist, string Name, DateTime? ReleaseDate, int NumberOfDiscs = 1)
    : Record(Artist, Name, ReleaseDate);