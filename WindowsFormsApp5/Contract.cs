using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Contract
    {
        public int ContractId { get; private set; }
        public int EmployeeId { get; private set; }
        public bool Active { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string ReasonForEnding { get; private set; }

        public Contract(int contractId, int employeeId, bool active, DateTime startDate, DateTime endDate, string reasonForEnding)
        {
            ContractId = contractId;
            EmployeeId = employeeId;
            Active = active;
            StartDate = startDate;
            EndDate = endDate;
            ReasonForEnding = reasonForEnding;
        }
    }
}
