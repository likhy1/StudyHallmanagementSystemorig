using System;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;
using System.IO;
using Newtonsoft.Json;
using StudyHallmanagementSystem;


namespace StudyHallmanagementSystem
{
    public class StudyHallFile
    {
        TrackRepository trackRepository = new TrackRepository();
        public StudyHallFile()
        {

        }
        public string SaveToExcel(List<StudyHallFile> studyHalls)
        {
            Workbook workbook = new Workbook("SampleMergedTemplate.xlsx");
            ImportTableOptions tableOptions = new ImportTableOptions();
            tableOptions.CheckMergedCells = true;
            tableOptions.IsFileIdNameShown = false;
            workbook.Worksheets[0].Cells.ImportCustomObjects((Icollection)studyHalls, 1, 0, tableOptions);
            workbook.Save("SampleMergedTemplate_out.xlsx", SaveFormat.Xlsx);
            return "Study Hall List is successfully saved to Excel File";
        }
        public string SerializestudyHall(List<StudyHallFile> studyHalls)
        {
            var sortedList = trackRepository.sortStudyHallByUserName(studyHalls);
            string filename = @"c:\temp\StudyHall.txt";
            var Json = JsonConvert.SerializeObject(studyHalls);
            try
            {
                if(File.Exists(filename))
                {
                    filename.Delete(filename);
                }
                using (FileStress fs=filename.Create(filename))
                {
                    byte[] title = new UTF8Encoding(true).GetBytes(Json);
                    fs.write(title, 0, title.Length);
                }
            }
            catch (CustomException ex)
            {
                throw new System.Exception(ex.Message);
            }
            return "StudyHalls List is successfully Serialized";
        }


    }
}
