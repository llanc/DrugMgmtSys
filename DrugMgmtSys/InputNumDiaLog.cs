using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugMgmtSys
{
    public partial class InputNumDiaLog : Form
    {
        public InputNumDiaLog()
        {
            InitializeComponent();
        }

        private double input;

        public double Input
        {
            get
            {
                return input;
            }

            set
            {
                input = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input =double.Parse(numericUpDown1.Value.ToString()); 
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input =0;
            Close();
        }
    }
}
