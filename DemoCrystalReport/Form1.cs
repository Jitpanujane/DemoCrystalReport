using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace DemoCrystalReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewReport_Click(System.Object sender, System.EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            // to get the location the assembly is executing from
            //(not necessarily where the it normally resides on disk)
            // in the case of the using shadow copies, for instance in NUnit tests, 
            // this will be in a temp directory.
            string path1 = System.Reflection.Assembly.GetExecutingAssembly().Location;

            //To get the location the assembly normally resides on disk or the install directory
            string path2 = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;

            //once you have the path you get the directory with:
            var directory1 = System.IO.Path.GetDirectoryName(path1);

            //rpt.Load(directory & "\myCrystalReport.rpt")
            rpt.Load($"{directory1}\\myCrystalReport.rpt");
            this.CrystalReportViewer1.ReportSource = rpt;
            this.CrystalReportViewer1.Refresh();
        }
    }
}
