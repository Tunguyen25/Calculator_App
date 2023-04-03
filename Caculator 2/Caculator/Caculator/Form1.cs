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
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnSo0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtODuLieu.Text += bt.Text;
        }

       
       
        private void btnCham_Click(object sender, EventArgs e)
        {
            if(!txtODuLieu.Text.Contains("."))
            {
                txtODuLieu.Text += ".";
            }    
        }

        private void btnAm_Click(object sender, EventArgs e)
        {
            if (txtODuLieu.Text.Contains("-"))
                txtODuLieu.Text = txtODuLieu.Text.Trim('-');
            else
                txtODuLieu.Text = "-" + txtODuLieu.Text;

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtODuLieu.Text);
            txtODuLieu.Clear();
            Button bt = (Button)sender;
            operators = bt.Text;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            switch(operators)
            {
                case "+":
                    valueSecond = decimal.Parse(txtODuLieu.Text);
                    Result = valueSecond + valueFirst;
                    txtODuLieu.Text = Result.ToString();
                    break;
            }    
        }
    }
}
