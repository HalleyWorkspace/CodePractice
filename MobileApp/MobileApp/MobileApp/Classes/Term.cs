using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileApp.Classes
{
    public class Term
    {
        [PrimaryKey, AutoIncrement]
        public int? TermID { get; set; }
        public String TermName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        
    }
}
