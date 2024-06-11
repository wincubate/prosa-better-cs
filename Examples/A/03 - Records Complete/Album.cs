using System;

public record Album(string Artist, string AlbumName, DateTime ReleaseDate)
{
    public int Age
    {
        get
        {
            DateTime today = DateTime.Now;
            return today.Year - ReleaseDate.Year - (ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
        }
    }
}