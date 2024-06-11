using System;

Album album = new(
    "Depeche Mode", 
    "Violator", 
    new DateTime(1990, 03, 19)
);
Console.WriteLine(album.Age);

//album.Artist = "Somebody Else";
