using StatsGraph.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace StatsGraph.Helper
{
    class FileParser
    {
        /*  Method Name: ReadCSVFile
         *      Purpose: Reads CSV file and parses through the data and add the statistics
         *      Accepts: string path variable
         *      Returns: ObservableCollection<StatsModel> 
         */
         public static ObservableCollection<StatsModel> ReadCSVFile(string path)
        {
            string[] linesFromFile;

            linesFromFile = File.ReadAllLines(path);

            ObservableCollection<StatsModel> csvData = new ObservableCollection<StatsModel>();
            StatsModel statHold = new StatsModel();

            for (int i = 1; 1 < linesFromFile.Length; i++)
            {
                //Split data from string array
                string[] hold;
                hold = linesFromFile[i].Split('"');
                //add split data to a StatModel
                statHold.Geography = hold[0].Trim(',');
                statHold.Amount = (int)double.Parse(hold[1]);
                statHold.Quarter = hold[2].Trim(',');
                //Add new StatModel to 
                csvData.Add(statHold);
            }
            return csvData;
        }

        /*  Method Name: WriteCSVFile
         *      Purpose: Writes StatsModel collection to a csv file
         *      Accepts: ObservableCollection<statsModel>, string
         *      Returns: void
         */ 
         public static void WriteCSVFile(ObservableCollection<StatsModel> oc, string path)
        {
            List<string> fileLines = new List<string>();
            fileLines.Add("Geopgraphy, Amount, Quarter");

            foreach(var sm in oc)
            {
                string hold = "";
                //Strip the data from oc and add to file lines
                string geoHold = sm.Geography;
                string popHold = (Convert.ToString(sm.Amount));
                string quartHold = sm.Quarter;

                hold += geoHold + ",";
                hold += "\"" + popHold + "\",";
                hold += quartHold;
                fileLines.Add(hold);
            }
            File.WriteAllLines(path, fileLines);
        }
    }
}
