using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCalculator
{
    public partial class fmResult : Form
    {
        public List<Result> Results { get; set; }

        public fmResult(List<Result> results)
        {
            Results = results;
            InitializeComponent();
        }

        private void fmResult_Load(object sender, EventArgs e)
        {
            dgv.DataSource = Results;
            dgv.AutoGenerateColumns = false;
        }

    }
}
