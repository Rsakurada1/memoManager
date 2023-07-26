using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memo.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aditButtonClicked(object sender, EventArgs e)
        {

        }

        private void removeButtonClicked(object sender, EventArgs e)
        {

        }

        private void addButtonClicked(object sender, EventArgs e)
        {
            memoDataSet.memoDataTable.AddmemoDataTableRow(
                this.dateText.Text, this.titletext.Text);
        }
    }
}
