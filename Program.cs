using System;
using System.Linq;
using System.Collections.Generic;



namespace musicanalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine(" MusicPlaylistAnalyzer <music_playlist_file_path> <report_file_path>");
                Environment.Exit(1);
            }

            string txtFilePath = args[0];
            string reportFilePath = args[1];

            List<MusicStats> musicStatsList = null;
            try
            {
                musicStatsList = musicstatsloader.Load(txtFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(2);
            }

            var report = MusicStatsReport.GenerateText(musicStatsList);

            try
            {
                System.IO.File.WriteAllText(reportFilePath, report);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(3);
            }
        }
    }
}
