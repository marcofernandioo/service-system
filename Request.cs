using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    public class Request
    {
        string requestID { get; set; }
        string columnRequestID
        {
            get { return requestID; }
        }
        string datePaid { get; set; }
        string serviceType { get; set; }
        string urgency { get; set; }
        string customerUsername { get; set; }
        string technicianUsername { get; set; }
        string RequestInfo 
        { 
            get
            {
                return $"{requestID} | {datePaid} | {customerUsername}";
            } 
        }

        public Request ()
        {

        }
    }
}
