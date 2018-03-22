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
    public partial class ShowOrder : Form
    {
        public ShowOrder()
        {
            InitializeComponent();
        }
        public ShowOrder(string[] message)
        {
            InitializeComponent();
            richTextBox1.Text = message[0];
            label2.Text = message[1]+"元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
