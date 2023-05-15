using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment
{
    internal class FileManagement
    {
        public string[] GetFileList(string folderPath)
        {
            static string[] GetFileList(string folderPath) => Directory.GetFiles(folderPath).Select(Path.GetFileName).ToArray();

            //string[] files = GetFileList(folderPath);
            return GetFileList(folderPath);
        }
        

    }

    public class TOU_Csv_Layout
    {
        public long MeterPointCode { get; set; }
        public string? SerialNumber { get; set; }
        public string? PlantCode { get; set; }
        public DateTime? dateTime { get; set; }
        public string? DataType { get; set; }
        public decimal? Energy { get; set; }
        public decimal? MaxumumDemand { get; set; }
        public string? TimeOfMaxDemand { get; set; }
        public string? Units { get; set; }
        public string? Status { get; set; }
        public string? Period { get; set; }
        public string? DLSActive { get; set; }
        public int? BillingResetCount { get; set; }
        public DateTime? BillingResetDateTime { get; }
        public string? Rate { get; set; }
    }


    public class PL_Csv_Layout
    {
        public long MeterPointCode { get; set; }
        public string? SerialNumber { get; set; }
        public string? PlantCode { get; set; }
        public DateTime? dateTime { get; set; }
        public string? DataType { get; set; }
        public decimal? DataValue { get; set; }
        public string? Units { get; set; }
        public string? Status { get; set; }
    }


}
