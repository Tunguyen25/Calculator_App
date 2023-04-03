using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class CalenderCalcs : Form
    {   
        public CalenderCalcs()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            lbResult.Text = "Same dates";
            lbResult1.Text = "";
        }
        private void btnDifference_Click(object sender, EventArgs e)
        {
            DateDifferData dateDifferData = new DateDifferData(fromDate.Value,toDate.Value);
            if(fromDate.Value == toDate.Value)
            {
                lbResult.Text = "Same dates";
            }
            else
            {
                lbResult.Text = "Not same dates";
                lbResult1.Text = dateDifferData.Days.ToString() + " "+ "days" + " " + "\n"+ dateDifferData.Hours.ToString() + " " + "Hours";
            }

         }
        public class DateDifferData
        {
            public int Years;
            public int Months;
            public int Hours;
            public int Days;
            public int Minutes;
            public int Seconds;
            public DateDifferData(DateTime fromDate, DateTime toDate)
            {
                var differ = fromDate - toDate;
                Days = (int)differ.TotalDays;
                Days = Math.Abs(Days);
                Minutes = (int)differ.TotalMinutes;
                Minutes = Math.Abs(Minutes);
                Hours = (int)differ.TotalHours;
                Hours = Math.Abs(Hours);
                Years = Days / 365;
                Months = Days / 30;
            }

            public override string ToString()
            {
                return $" {Years} Years {Environment.NewLine} {Months} Months {Environment.NewLine} {Days} Days";
            }

        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStandard fStd = new FrmStandard();
            fStd.ShowDialog();
            this.Close();
        }

        private void btnSci_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSci fSci = new FrmSci();
            fSci.ShowDialog();
            this.Close();
        }
    }
}
