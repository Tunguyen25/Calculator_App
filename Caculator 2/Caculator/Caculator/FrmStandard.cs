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
    public partial class FrmStandard : Form
    {
        private double valueFirst;
        private double valueSecond;
        private double Result;
        private string operators;
        public FrmStandard()
        {
            InitializeComponent();
        }
        void init()
        {
            valueFirst = 0;
            valueSecond = 0;
            Result = 0;
            operators = "";
            txtODuLieu.Text = "";
            lbKQ.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                timer1.Stop();
                this.BackColor = Color.White;
                this.Opacity = 1;
            }
            else
            {
                this.BackColor = Color.Black;
                this.Opacity = 1;
            }

        }

        private void btSang_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Black)
            {
                btnSang.Show();
                this.BackColor = Color.White;
                btnToi.Hide();
            }
            else
            {
                btnSang.Hide();
                this.BackColor = Color.Black;
                btnToi.Show();
            }
        }
        private void btnSo0_Click(object sender, EventArgs e)
        {
            if (txtODuLieu.Text == "0" || txtODuLieu.Text == null)
            {
                txtODuLieu.Text = "";
            }
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
            if (String.IsNullOrEmpty(txtODuLieu.Text))
            {
                MessageBox.Show("Khong hop le");
            }
            else
            {
                valueFirst = double.Parse(txtODuLieu.Text);
                txtODuLieu.Clear();
                Button bt = (Button)sender;
                operators = bt.Text;
        }
            }
        

        private void btnBang_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operators)
                {
                    case "+":
                        valueSecond = double.Parse(txtODuLieu.Text);
                        Result = valueSecond + valueFirst;
                        txtODuLieu.Text = Result.ToString();
                        RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                        break;
                    case "-":
                        valueSecond = double.Parse(txtODuLieu.Text);
                        Result = valueFirst - valueSecond;
                        txtODuLieu.Text = Result.ToString();
                        RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                        break;
                    case "x":
                        valueSecond = double.Parse(txtODuLieu.Text);
                        Result = valueSecond * valueFirst;
                        txtODuLieu.Text = Result.ToString();
                        RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                        break;
                    case "/":
                        try
                        {
                            valueSecond = double.Parse(txtODuLieu.Text);
                            Result = valueFirst / valueSecond;
                            txtODuLieu.Text = Result.ToString();
                            RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                            lbKQ.Text = Result.ToString();

                            if (valueSecond == 0)
                            {
                                throw new DivideByZeroException("Số chia phải khác không");

                            }
                            txtODuLieu.Clear();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Bạn phải nhập 2 số");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case "x²":
                        //valueSecond = double.Parse(txtODuLieu.Text);
                        Result = Math.Pow(valueFirst, 2);
                        txtODuLieu.Text = Result.ToString();
                        RtBoxDisplayHistory.AppendText($"{valueFirst}²  = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                        break;
                    case "√()":
                        //valueSecond = double.Parse(txtODuLieu.Text);
                        Result = Math.Sqrt(valueFirst);
                        txtODuLieu.Text = Result.ToString();
                        RtBoxDisplayHistory.AppendText($" √({valueFirst}) = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                        break;
                    case "%":
                        valueSecond = double.Parse(txtODuLieu.Text);
                        Result = valueFirst % valueSecond;
                        txtODuLieu.Text = Result.ToString();
                        RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                        break;
                    case "1/x":
                        //valueSecond = double.Parse(txtODuLieu.Text);
                        Result = 1 / valueFirst;
                        txtODuLieu.Text = Result.ToString();
                        RtBoxDisplayHistory.AppendText($" 1/({valueFirst}) = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                        break;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số quá lớn hãy nhập số khác");
                txtODuLieu.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtODuLieu.Text == "") 
                return;
            txtODuLieu.Text = txtODuLieu.Text.Substring(0, txtODuLieu.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            init();

        }

        private void btnSci_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSci fSci = new FrmSci();
            fSci.ShowDialog();
            this.Close();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalenderCalcs Calen = new CalenderCalcs();
            Calen.ShowDialog();
            this.Close();
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            pnlHistory.Height = (pnlHistory.Height == 17) ? pnlHistory.Height = 255 : 17;
            /* pnlHistory.Height = pnlHistory.Height != 17 ? 17 : pnlHistory.Height = 300;*/

            if (pnlHistory.Height == 255)
            {

                RtBoxDisplayHistory.BackColor = Color.LightGray;
                btDelHistory.Show();
                btDelHistory.BackColor = Color.White;
            }
            else
            {
                RtBoxDisplayHistory.BackColor=Color.LightGray;
                btDelHistory.Hide();
            }
        }
        private void btDelHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
        }
    }
}
