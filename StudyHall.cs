using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudyHallmanagementSystem
{
    public class StudyHall
    {
        public int StudyHallid { get; set; }
        public string StudyHallName { get; set; }
        public int NoofStudyHalls { get; set; }
        public string Location { get; set; }

        public StudyHall(int studyHallid, string studyHallName , int noofStudyHalls, string location)
        {
            StudyHallid = studyHallid;
            StudyHallName = studyHallName;
            NoofStudyHalls = noofStudyHalls;
            Location = location;

        }
      
    }
}
