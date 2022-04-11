using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Globalization;

namespace WindowsFormsApp5.ucM
{
    public partial class ucMStatistics : UserControl
    {
        public ucMStatistics()
        {
            InitializeComponent();
            s = new SQL();
            int[] counters = new int[13];
            counters[0] = 0;
            int[] countersD = new int[13];
            countersD[0] = 0;
            for(int i = 1; i <= 12; i++)
            {
                DateTimeFormatInfo dinfo = new DateTimeFormatInfo();
                counters[i] = 0;
                countersD[i] = 0;
                foreach(Contract c in s.GetContracts())
                {
                    if (c.StartDate.Month == i)
                        counters[i]++;
                    if (c.EndDate.Month == i && c.EndDate.Year > 2000)
                        countersD[i]++;
                }
                noOfHiredEmployees.Add(dinfo.GetMonthName(i), counters[i]);
                noOfDeactivatedEmployees.Add(dinfo.GetMonthName(i), countersD[i]);
            }
            var maxHired = noOfHiredEmployees.Values.Max();
            var maxDeactivated = noOfDeactivatedEmployees.Values.Max();
            if (maxHired > maxDeactivated)
                largestValue = maxHired;
            else
                largestValue = maxDeactivated;
            foreach(ProgressBar pb in this.Controls.OfType<ProgressBar>().ToList())
            {
                string getMonth;
                if(pb.Name.Contains("Hired"))
                {
                    getMonth = pb.Name.Substring(11, pb.Name.Length - 1 - 5 - 10);
                    pb.Value = (noOfHiredEmployees[getMonth]*100) / largestValue;
                }
                if(pb.Name.Contains("Deactivated"))
                {
                    getMonth = pb.Name.Substring(11, pb.Name.Length - 1 - 11 - 10);
                    pb.Value = (noOfDeactivatedEmployees[getMonth]*100) / largestValue;
                }
                
            }
            foreach(ProgressBar pb in this.Controls.OfType<ProgressBar>().ToList())
            {
                if (pb.Name.Contains("Deactivated"))
                    pb.SetState(2);
            }
        }

        SQL s;
        Dictionary<string, int> noOfHiredEmployees = new Dictionary<string, int>();
        Dictionary<string, int> noOfDeactivatedEmployees = new Dictionary<string, int>();
        int largestValue;
    }
}
