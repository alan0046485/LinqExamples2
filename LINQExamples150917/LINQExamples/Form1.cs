using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
All LINQ query expressions using query syntax **MUST** begin with a from clause and **MUST** end
with a select or group clause. Method syntax **CAN** drop the select extension method call
when no projection is required.
*/
namespace LINQExamples
{
    public partial class Form1 : Form
    {
        string[] wordArray = { "downward", "atomic", "annihilate", "port", "parallel",
                            "attribute", "backbone", "skyline", "aardvark", "evaluate",
                            "entity", "apparent", "agreeable", "blink", "belong", "ethical",
                            "polar", "elegant", "audience"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Examples of using our own extension methods...
            string myString = "toby";
            myString = myString.CapitaliseFirstLetter();
            // Following example shows that extension methods are nothing more than static
            // functions.
            string myString2 = MyExtensionMethods.CapitaliseFirstLetter("hello");

            DateTime date1 = new DateTime(2017, 9, 8);
            if(DateTimeExtensions.IsTargetDateBetweenStartAndEndDates(date1,
                                                                     new DateTime(2017, 8, 31),
                                                                     new DateTime(2017, 9, 10)))
            {
                //MessageBox.Show("September 8th lies between August 31st & 10th September");
            }

            foreach (var item in wordArray)
            {
                rtbNumbers.AppendText(item + Environment.NewLine);
            }
        }

        private void btnBasicQuery_Click(object sender, EventArgs e)
        {
            rtbBasicQueryValues.Clear();

            // Query syntax
            var solutionSet = from entry in wordArray
                              where entry.EndsWith("te")
                              select entry;
            // Method syntax
            var methodSyntaxSolutionSet = wordArray
                                            .Where(entry => entry.EndsWith("te"));
                                            //.Select(entry => entry);
            
            foreach (var item in solutionSet)
            {
                rtbBasicQueryValues.AppendText(item + Environment.NewLine);
            }
        }

        private void btnSortQuery_Click(object sender, EventArgs e)
        {
            rtbSortQueryValues.Clear();

            var solutionSet = from entry in wordArray
                              orderby entry
                              select entry;

            var methodSyntaxSolutionSet = wordArray
                                            .OrderBy((entry) => entry);

            foreach (var item in solutionSet)
            {
                rtbSortQueryValues.AppendText(item + Environment.NewLine);
            }
        }

        private void btnFilterQuery_Click(object sender, EventArgs e)
        {
            rtbFilterQueryValues.Clear();

            var solutionSet = from entry in wordArray
                              where entry.StartsWith("a")
                              select entry;

            foreach (var item in solutionSet)
            {
                rtbFilterQueryValues.AppendText(item + Environment.NewLine);
            }

            /*
            With LINQ we can also work with the results from previous LINQ queries.
            Note the descending keyword used in the orderby line--there is also an
            ascending keyword too, but it is rather redundant as the default orderby
            is in ascending order.
            */
            IEnumerable<string> sortedSolutionSet = from entry in solutionSet
                                                    orderby entry descending
                                                    select entry;

            rtbFilterQueryValues.AppendText("-------" + Environment.NewLine);

            foreach (var item in sortedSolutionSet)
            {
                rtbFilterQueryValues.AppendText(item + Environment.NewLine);
            }
        }

        private void btnSortNFilterQuery_Click(object sender, EventArgs e)
        {
            rtbSortNFilterQueryValues.Clear();

            IEnumerable<string> solutionSet = from entry in wordArray
                                              where entry.StartsWith("a")
                                              orderby entry descending
                                              select entry;

            foreach (var item in solutionSet)
            {
                rtbSortNFilterQueryValues.AppendText(item + Environment.NewLine);
            }
        }

        private void btnMoreExamples_Click(object sender, EventArgs e)
        {
            using (AdvancedExamplesFrm advExFrm = new AdvancedExamplesFrm())
            {
                advExFrm.ShowDialog();
            }
        }
    }
}
