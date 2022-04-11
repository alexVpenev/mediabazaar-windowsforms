using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Employee
    {   
        public int id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string emailAddress { get; private set; }
        public DateTime dateOfBirth { get; private set; }
        public string phoneNo { get; private set; }  
        public string address { get; private set; }
        public bool maritalStatus { get; private set; }
        public string BSN { get; private set; }
        public bool fulltime { get; private set; }
        public double FTE { get; private set; }
        public double salary { get; private set; }
        public string emergencyNo { get;private set; }
        public string position { get; private set; }
        public int departmentId { get; private set; }
        public string departmentName { get; private set; }
        public string password { get; private set; } 


        public Employee(int id,
                        string firstName,
                        string lastName,
                        string emailAddress,
                        DateTime dateOfBirth,
                        string phoneNo,
                        string address,
                        bool maritalStatus,
                        string bSN,
                        bool fulltime,
                        double fTE,
                        double salary,
                        string emergencyNo,
                        int departmentId,
                        string departmentName,
                        string position,
                        string password)
        {
            this.id = id;
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.emailAddress = emailAddress ?? throw new ArgumentNullException(nameof(emailAddress));
            this.dateOfBirth = dateOfBirth;
            this.phoneNo = phoneNo ?? throw new ArgumentNullException(nameof(phoneNo));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.maritalStatus = maritalStatus;
            this.BSN = bSN ?? throw new ArgumentNullException(nameof(bSN));
            this.fulltime = fulltime;
            this.FTE = fTE;
            this.salary = salary;
            this.emergencyNo = emergencyNo ?? throw new ArgumentNullException(nameof(emergencyNo));
            this.departmentId = departmentId;
            this.departmentName = departmentName ?? throw new ArgumentNullException(nameof(departmentName));
            this.position = position ?? throw new ArgumentNullException(nameof(position));
            this.password = password;
        }

        public string[] GetDisplayInfo()
        {
            return new string[] { this.id.ToString(), this.firstName + " " + this.lastName};
        }
    }
}
