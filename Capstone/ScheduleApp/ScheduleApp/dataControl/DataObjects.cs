using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.dataControl
{
    class DataObjects
    {
    }

    public class scheduleObject
    {
        public int apointmentID { get; set; }
        public DateTime date { get; set; }
        public string customerName { get; set; }
        public int customerID { get; set; }
        public string consultantName { get; set; }
        public int consultantId { get; set; }
        public string type { get; set; }
    }

    public class customerObject
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string phoneNumber { get; set; }
    }

    public class consultantObject 
    { 
        public int consultantId { get; set; }
        public string consultantName { get; set; }
        public string password { get; set; }
    }


}
