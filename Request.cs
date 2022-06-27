using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    public class Request
    {
        public int requestID { get; set; }
        public string datePaid { get; set; }
        public string serviceType { get; set; }
        public string urgency { get; set; }
        public int customerID { get; set; }
        public int technicianID { get; set; }
        

        public Request ()
        {

        }

        public Request(int requestID, string datePaid, string serviceType, string urgency, int customerID, int technicianID)
        {
            this.requestID = requestID;
            this.datePaid = datePaid;
            this.serviceType = serviceType;
            this.urgency = urgency;
            this.customerID = customerID;
            this.technicianID = technicianID;
        }

    }
}
