using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileApp.Classes
{

    public class Class
    {
        [PrimaryKey, AutoIncrement]
        public int? ClassID { get; set; }
        public string ClassName { get; set; }
        public string Status { get; set; }
        public string InstructorName { get; set; }
        public string InstructorPhone { get; set; }
        public string InstructorEmail { get; set; }
        public bool Notification { get; set; }
        public string Notes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? TermID { get; set; }
    }
}
