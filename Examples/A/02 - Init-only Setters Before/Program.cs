using System;

Album album = new Album(
    "Depeche Mode",
    "Violator",
    new DateTime(1990, 03, 19)
);
Console.WriteLine(album.Age);

class Album
{
    public string Artist { get; }
    public string AlbumName { get; }
    public DateTime ReleaseDate { get; }

    public int Age
    {
        get
        {
            DateTime today = DateTime.Now;
            return today.Year - ReleaseDate.Year - (ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
        }
    }

    public Album(
        string artist,
        string albumName,
        DateTime releaseDate
    )
    {
        Artist = artist;
        AlbumName = albumName;
        ReleaseDate = releaseDate;
    }
}