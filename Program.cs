
using CodeAssessment;

CalculateMedian calculateMedian = new CalculateMedian();
CalculateAbove calculateAbove = new CalculateAbove();
CalculateBelow calculateBelow = new CalculateBelow();

FileManagement manageFiles = new FileManagement();

String[] medianValueReturn;
List<string> medianValueToReturn = new List<string>();

Double[] aboveMedian;
Double[] belowMedian;
Double medianValue = 0;

int columnIndex = 5;
int dateIndex = 3;

string folderPath = "D:\\CodeAssessment\\AssessmentFiles";
string[] fileList = manageFiles.GetFileList(folderPath);
string valueToWrite = String.Empty;

foreach (string file in fileList)
{
    medianValueReturn = calculateMedian.FindMedian(folderPath, file, columnIndex, dateIndex);

    //BS; Commented out since these updates would not allow compile yet
    //medianValue = double.Parse(medianValueReturn[2]);
    //belowMedian = calculateBelow.FindBelow20(folderPath, file, columnIndex, dateIndex, medianValue);



    Console.WriteLine(medianValueReturn[0]);


}
Console.ReadKey();
