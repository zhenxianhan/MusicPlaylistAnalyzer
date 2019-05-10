﻿using System;
namespace musicanalyzer
{
    public class MusicStats
    {
       
           
            public string Name;
            public string Artist;
            public string Album;
            public string Genre;
            public int Size;
            public double Time;
            public int Year;
            public int Plays;
            


            public MusicStats(string name, string artist, string album, string genre,
                             int size, double time, int year, int plays)
            {
                Name = name;
                Artist = artist;
                Album = album;
                Genre = genre;
                Size = size;
                Time = time;
                Year = year;
                Plays = plays;
                
            }
        override public string ToString()
        {
            return String.Format("Name: {0}, Artist: {1}, Album: {2}, Genre: {3}, Size: {4}, Time: {5}, Year: {6}, Plays: {7}", Name, Artist, Album, Genre, Size, Time, Year, Plays);
        }

    }
}

