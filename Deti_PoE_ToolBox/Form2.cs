using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deti_PoE_ToolBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public string LabelText
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }

        public void ShowIt(int dfq)
        {
            if (dfq == 1)
            {
                this.Show();
            }
            if (dfq == 0)
            {
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
