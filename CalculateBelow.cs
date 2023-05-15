using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment
{
    internal class CalculateBelow
    {
        //BS; Commented out completely to allow successful compile
        //internal Double[] FindBelow20(string folderPath, string file, int dataIndex, int dateIndex, double median)
        //{
        //    List<string> result = new List<string>();
        //    double dataValue = 0;
        //    double medianResults = 0;

        //    string tempFormatter = String.Empty;
        //    string dateValue = string.Empty;

        //    try
        //    {
        //        string[] csvLines = File.ReadAllLines((folderPath + "//" + file));
        //        double[] columnValues = new double[csvLines.Length - 1]; //BS; subtract 1 to exclude the header row

        //        for (int i = 1; i < csvLines.Length; i++) //BS; start from 1 to exclude the header row
        //        {
        //            string[] rowValues = csvLines[i].Split(',');

        //            if (double.TryParse(rowValues[dataIndex], out dataValue))
        //            {
        //                columnValues[i - 1] = dataValue;
        //            }
        //            dateValue = rowValues[dateIndex].ToString();
        //        }

        //        Array.Sort(columnValues);

        //        if (columnValues.Length % 2 == 0)
        //        {
        //            medianResults = (columnValues[(columnValues.Length / 2) - 1] + columnValues[columnValues.Length / 2]) / 2;
        //        }
        //        else
        //        {
        //            medianResults = columnValues[columnValues.Length / 2];
        //        }
        //        tempFormatter = $"FileName: {file}  Date/Time: {dateValue.ToString()}  Median: {medianResults.ToString()}";

        //        result.Add(tempFormatter);

        //        Console.WriteLine($"FileName: {file}  Date/Time: {dateValue}  Median: {medianResults}");

        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //        return null;
        //    }
        //}

    }
}
