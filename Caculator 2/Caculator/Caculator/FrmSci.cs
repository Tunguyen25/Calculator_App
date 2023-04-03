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
    public partial class FrmSci : Form
    {
        private double valueFirst;
        private double valueSecond;
        private double Result;
        private string operators;
        const double π = 3.14;
        const double e = 2.71;

        public FrmSci()
        {
            InitializeComponent();
        }
        void init()
        {
            valueFirst = 0;
            valueSecond = 0;
            Result = 0;
            operators = "";
            lbKQ.Text = "";
            txtODuLieu.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
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
            if (this.BackColor != Color.Black)
            {
                btnSang.Hide();
                this.BackColor = Color.Black ;
                btnToi.Show();
            }
            else
            {
                btnSang.Show();
                this.BackColor = Color.White;
                btnToi.Hide();
            }
        }
        private void btnSo0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtODuLieu.Text += bt.Text;
        }
        static long tinhGiaithua(int n)
        {
            int i;
            long giai_thua = 1;
            if (n == 0 || n == 1)
            {
                return giai_thua;
            }
            else
            {
                for (i = 2; i <= n; i++)
                {
                    giai_thua *= i;
                }
                return giai_thua;
            }
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!txtODuLieu.Text.Contains("."))
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
                Button bt = (Button)sender;
                operators = bt.Text;
                txtODuLieu.Text = "";
            }
            
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    valueSecond = double.Parse(txtODuLieu.Text);
                    Result = valueFirst + valueSecond;
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
                    Result = valueFirst * valueSecond;
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
                case "Abs()":
                    string t1 = txtODuLieu.Text;
                    t1 = t1.Substring(4, t1.Length - 4);
                    t1 = t1.Substring(0, t1.Length - 1);
                    valueFirst = double.Parse(t1);
                    Result = Math.Abs(valueFirst);
                    RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                    lbKQ.Text = Result.ToString();
                    break;
                case "!":
                    string t2 = txtODuLieu.Text;
                    t2 = t2.Substring(0, t2.Length - 1);
                    try
                    {
                        valueFirst = int.Parse(t2);
                        Result = tinhGiaithua((int)valueFirst);
                        RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Khong hop le");
                    }
                    break;
                case "ln()":
                    string t3 = txtODuLieu.Text;
                    t3 = t3.Substring(3, t3.Length - 3);
                    t3 = t3.Substring(0, t3.Length - 1);
                    try
                    {
                        valueFirst = double.Parse(t3);
                        Result = Math.Log(valueFirst);
                        RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                        lbKQ.Text = Result.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Khong hop le");
                    }
                    break;
                case "x²":
                    Result = Math.Pow(valueFirst, 2);
                    txtODuLieu.Text = Result.ToString();
                    RtBoxDisplayHistory.AppendText($"{valueFirst}²  = {Result.ToString()}\n");
                    lbKQ.Text = Result.ToString();
                    break;
                case "%":
                    valueSecond = double.Parse(txtODuLieu.Text);
                    Result = valueFirst % valueSecond;
                    txtODuLieu.Text = Result.ToString();
                    RtBoxDisplayHistory.AppendText($" {valueFirst} {operators} {valueSecond} = {Result.ToString()}\n");
                    lbKQ.Text = Result.ToString();
                    break;
                case "10^x":
                    Result = Math.Pow(10, valueFirst);
                    txtODuLieu.Text = Result.ToString();
                    RtBoxDisplayHistory.AppendText($"10^{valueFirst}  = {Result.ToString()}\n");
                    lbKQ.Text = Result.ToString();
                    break;
                case "x^y":
                    valueSecond = double.Parse(txtODuLieu.Text);
                    Result = Math.Pow(valueFirst, valueSecond);
                    txtODuLieu.Text = Result.ToString();
                    RtBoxDisplayHistory.AppendText($" {valueFirst} ^ {valueSecond} = {Result.ToString()}\n");
                    lbKQ.Text = Result.ToString();
                    break;
                case "1/x":
                    Result = 1 / valueFirst;
                    txtODuLieu.Text = Result.ToString();
                    RtBoxDisplayHistory.AppendText($" 1/({valueFirst}) = {Result.ToString()}\n");
                    lbKQ.Text = Result.ToString();
                    break;
                case "√()":
                    Result = Math.Sqrt(valueFirst);
                    txtODuLieu.Text = Result.ToString();
                    RtBoxDisplayHistory.AppendText($" √({valueFirst}) = {Result.ToString()}\n");
                    lbKQ.Text = Result.ToString();
                    break;
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtODuLieu.Text))
            {
                MessageBox.Show("Khong hop le");
            }
            else
            {
                if (txtODuLieu.Text.Contains("Abs"))
                {
                    txtODuLieu.Text = txtODuLieu.Text.Substring(4, txtODuLieu.Text.Length - 4);

                    txtODuLieu.Text = txtODuLieu.Text.Substring(0, txtODuLieu.Text.Length - 1);
                }
                else
                {
                    txtODuLieu.Text = "Abs(" + txtODuLieu.Text + ")";
                    Button bt = (Button)sender;
                    operators = bt.Text;
                }

            }


        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtODuLieu.Text))
            {
                MessageBox.Show("Khong hop le");
            }
            else
            {
                if (txtODuLieu.Text.Contains("!"))
                {
                    txtODuLieu.Text = txtODuLieu.Text.Substring(0, txtODuLieu.Text.Length - 1);
                }
                else
                {
                    txtODuLieu.Text = txtODuLieu.Text + "!";
                    Button bt = (Button)sender;
                    operators = bt.Text;
                }

            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtODuLieu.Text))
            {
                MessageBox.Show("Khong hop le");
            }
            else
            {
                if (txtODuLieu.Text.Contains("ln"))
                {
                    txtODuLieu.Text = txtODuLieu.Text.Substring(3, txtODuLieu.Text.Length - 3);

                    txtODuLieu.Text = txtODuLieu.Text.Substring(0, txtODuLieu.Text.Length - 1);
                }
                else
                {
                    txtODuLieu.Text = "ln(" + txtODuLieu.Text + ")";
                    Button bt = (Button)sender;
                    operators = bt.Text;
                }

            }
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

        private void FrmSci_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStandard fStd = new FrmStandard();
            fStd.ShowDialog();
            this.Close();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtODuLieu.Text = "3.14";
            lbKQ.Text = txtODuLieu.Text;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtODuLieu.Text = "2.71";
            lbKQ.Text = txtODuLieu.Text;
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
            pnlHistory.Height = (pnlHistory.Height == 17) ? pnlHistory.Height = 330 : 17;
            /* pnlHistory.Height = pnlHistory.Height != 17 ? 17 : pnlHistory.Height = 300;*/

            if (pnlHistory.Height == 330)
            {

                RtBoxDisplayHistory.BackColor = Color.LightGray;
                btDelHistory.Show();
                btDelHistory.BackColor = Color.White;
            }
            else
            {
                RtBoxDisplayHistory.BackColor = Color.LightGray;
                btDelHistory.Hide();
            }
        }
        private void btDelHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
        }

    }

}
