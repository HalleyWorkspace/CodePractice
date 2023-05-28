using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileApp.Classes
{
    public class Assessment
    {
        [PrimaryKey, AutoIncrement]
        public int? AssessmentID { get; set; }
        public string AssessmentName { get; set; }
        public string AssessmentType { get; set; }
        public DateTime DueDate { get; set; }
        public bool Notifications { get; set; }
        public int? ClassID { get; set; }
    }
}
