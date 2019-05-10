using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace musicanalyzer
{
    public static class MusicStatsReport
    {



        public static string GenerateText(List<MusicStats> musicStatsList)
        {
            string report = "Music Playist Report\n\n";


          




            report += "Songs that received 200 or more plays:\n\n ";
            var moreplay = from musicStats in musicStatsList where musicStats.Plays > 200 select musicStats;

            foreach ( var musicStats in moreplay)
            {
                report += musicStats.ToString();
                report += "\n";

            }



            report += "Number of Alternative songs: ";

            var alre = from musicStats in musicStatsList where musicStats.Genre == "Alternative" select musicStats;
            if (alre.Count() > 0)
            {
                report += alre.Count();

                report += "\n\n";
            }


            report += "Number of Hip-Hop/Rap songs: ";

            var hip = from musicStats in musicStatsList where musicStats.Genre == "Hip-Hop/Rap" select musicStats;
            if (hip.Count() > 0)
            {
                report += hip.Count();

                report += "\n\n";
            }


            report += "Songs from the album Welcome to the Fishbowl:\n ";
            var WelcometotheFishbowl = from musicStats in musicStatsList where musicStats.Album == "Welcome to the Fishbowl" select musicStats;
            foreach (var musicStats in WelcometotheFishbowl)
            {
                report += musicStats.ToString();
                report += "\n";

            }
           

              report += "Songs from before 1970:\n\n ";
            var before1970 = from musicStats in musicStatsList where musicStats.Year < 1970 select musicStats;
            foreach (var musicStats in before1970)
            {
                report += musicStats.ToString();
                report += "\n";

            }
           

            report += "Song names longer than 85 characters:\n\n ";

            var longestname = from musicStats in musicStatsList where musicStats.Name.Length > 85  select musicStats;
            foreach (var musicStats in longestname)
            {
                report += musicStats.Name;
                report += "\n";
            }


            report += "Longest song:\n\n ";

            var longestsong = from musicStats in musicStatsList where musicStats.Time == ((from stats in musicStatsList select stats.Time).Max()) select musicStats;
            foreach (var musicStats in longestsong)
            {
                report += musicStats.ToString();
                report += "\n";

            }
           
            return report;
            }

          
        }
    }

