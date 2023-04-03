
namespace Caculator
{
    partial class FrmSci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSci));
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtODuLieu = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btHistory = new System.Windows.Forms.Button();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.btDelHistory = new System.Windows.Forms.Button();
            this.btn10Mux = new ePOSOne.btnProduct.Button_WOC();
            this.btnxMuy = new ePOSOne.btnProduct.Button_WOC();
            this.btnDel = new ePOSOne.btnProduct.Button_WOC();
            this.btnClear = new ePOSOne.btnProduct.Button_WOC();
            this.btnE = new ePOSOne.btnProduct.Button_WOC();
            this.btnAm = new ePOSOne.btnProduct.Button_WOC();
            this.btnModule = new ePOSOne.btnProduct.Button_WOC();
            this.btnMu2 = new ePOSOne.btnProduct.Button_WOC();
            this.btnPi = new ePOSOne.btnProduct.Button_WOC();
            this.btnGiaiThua = new ePOSOne.btnProduct.Button_WOC();
            this.btnPhanx = new ePOSOne.btnProduct.Button_WOC();
            this.btnLn = new ePOSOne.btnProduct.Button_WOC();
            this.btnAbs = new ePOSOne.btnProduct.Button_WOC();
            this.btnSqrt = new ePOSOne.btnProduct.Button_WOC();
            this.btnTru = new ePOSOne.btnProduct.Button_WOC();
            this.btnCong = new ePOSOne.btnProduct.Button_WOC();
            this.btnChia = new ePOSOne.btnProduct.Button_WOC();
            this.btnNhan = new ePOSOne.btnProduct.Button_WOC();
            this.btnBang = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo0 = new ePOSOne.btnProduct.Button_WOC();
            this.btnCham = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo4 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo5 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo6 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo7 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo8 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo9 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo3 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo2 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSo1 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSang = new ePOSOne.btnProduct.Button_WOC();
            this.btnToi = new ePOSOne.btnProduct.Button_WOC();
            this.btnCalender = new ePOSOne.btnProduct.Button_WOC();
            this.btnStandard = new ePOSOne.btnProduct.Button_WOC();
            this.pnlHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKQ
            // 
            this.lbKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbKQ.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbKQ.Location = new System.Drawing.Point(-1, 205);
            this.lbKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(456, 68);
            this.lbKQ.TabIndex = 99;
            this.lbKQ.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtODuLieu
            // 
            this.txtODuLieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtODuLieu.Enabled = false;
            this.txtODuLieu.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtODuLieu.ForeColor = System.Drawing.Color.Black;
            this.txtODuLieu.Location = new System.Drawing.Point(-1, 272);
            this.txtODuLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtODuLieu.Multiline = true;
            this.txtODuLieu.Name = "txtODuLieu";
            this.txtODuLieu.Size = new System.Drawing.Size(455, 64);
            this.txtODuLieu.TabIndex = 98;
            // 
            // btHistory
            // 
            this.btHistory.ForeColor = System.Drawing.Color.Black;
            this.btHistory.Location = new System.Drawing.Point(-3, 786);
            this.btHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(458, 58);
            this.btHistory.TabIndex = 179;
            this.btHistory.Text = "Lịch sử";
            this.btHistory.UseVisualStyleBackColor = true;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.Black;
            this.pnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.pnlHistory.Controls.Add(this.btDelHistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHistory.Location = new System.Drawing.Point(0, 813);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(454, 31);
            this.pnlHistory.TabIndex = 178;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.Black;
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Black;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 46);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ReadOnly = true;
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(454, 0);
            this.RtBoxDisplayHistory.TabIndex = 2;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // btDelHistory
            // 
            this.btDelHistory.BackColor = System.Drawing.Color.Black;
            this.btDelHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDelHistory.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btDelHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btDelHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btDelHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelHistory.ForeColor = System.Drawing.Color.Black;
            this.btDelHistory.Location = new System.Drawing.Point(0, 0);
            this.btDelHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDelHistory.Name = "btDelHistory";
            this.btDelHistory.Size = new System.Drawing.Size(454, 46);
            this.btDelHistory.TabIndex = 1;
            this.btDelHistory.Text = "Xóa";
            this.btDelHistory.UseVisualStyleBackColor = false;
            this.btDelHistory.Click += new System.EventHandler(this.btDelHistory_Click);
            // 
            // btn10Mux
            // 
            this.btn10Mux.BackColor = System.Drawing.Color.Transparent;
            this.btn10Mux.BorderColor = System.Drawing.Color.Silver;
            this.btn10Mux.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btn10Mux.FlatAppearance.BorderSize = 0;
            this.btn10Mux.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn10Mux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn10Mux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10Mux.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10Mux.ForeColor = System.Drawing.Color.Black;
            this.btn10Mux.Location = new System.Drawing.Point(-1, 712);
            this.btn10Mux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn10Mux.Name = "btn10Mux";
            this.btn10Mux.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn10Mux.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btn10Mux.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btn10Mux.Size = new System.Drawing.Size(86, 68);
            this.btn10Mux.TabIndex = 171;
            this.btn10Mux.Text = "10^x";
            this.btn10Mux.TextColor = System.Drawing.Color.White;
            this.btn10Mux.UseVisualStyleBackColor = false;
            this.btn10Mux.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnxMuy
            // 
            this.btnxMuy.BackColor = System.Drawing.Color.Transparent;
            this.btnxMuy.BorderColor = System.Drawing.Color.Silver;
            this.btnxMuy.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnxMuy.FlatAppearance.BorderSize = 0;
            this.btnxMuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnxMuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnxMuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxMuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxMuy.ForeColor = System.Drawing.Color.Black;
            this.btnxMuy.Location = new System.Drawing.Point(-1, 490);
            this.btnxMuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxMuy.Name = "btnxMuy";
            this.btnxMuy.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnxMuy.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnxMuy.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnxMuy.Size = new System.Drawing.Size(86, 68);
            this.btnxMuy.TabIndex = 170;
            this.btnxMuy.Text = "x^y";
            this.btnxMuy.TextColor = System.Drawing.Color.White;
            this.btnxMuy.UseVisualStyleBackColor = false;
            this.btnxMuy.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImage = global::Caculator.Properties.Resources.delete;
            this.btnDel.BorderColor = System.Drawing.Color.Silver;
            this.btnDel.ButtonColor = System.Drawing.Color.RosyBrown;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(-1, 418);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDel.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnDel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnDel.Size = new System.Drawing.Size(86, 68);
            this.btnDel.TabIndex = 165;
            this.btnDel.Text = "Del";
            this.btnDel.TextColor = System.Drawing.Color.White;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.ButtonColor = System.Drawing.Color.RosyBrown;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(-1, 344);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnClear.Size = new System.Drawing.Size(86, 68);
            this.btnClear.TabIndex = 164;
            this.btnClear.Text = "C";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.Transparent;
            this.btnE.BorderColor = System.Drawing.Color.Silver;
            this.btnE.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.Black;
            this.btnE.Location = new System.Drawing.Point(90, 344);
            this.btnE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnE.Name = "btnE";
            this.btnE.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnE.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnE.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnE.Size = new System.Drawing.Size(86, 68);
            this.btnE.TabIndex = 162;
            this.btnE.Text = "e";
            this.btnE.TextColor = System.Drawing.Color.White;
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnAm
            // 
            this.btnAm.BackColor = System.Drawing.Color.Transparent;
            this.btnAm.BorderColor = System.Drawing.Color.Silver;
            this.btnAm.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAm.FlatAppearance.BorderSize = 0;
            this.btnAm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAm.ForeColor = System.Drawing.Color.Black;
            this.btnAm.Location = new System.Drawing.Point(181, 344);
            this.btnAm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAm.Name = "btnAm";
            this.btnAm.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAm.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnAm.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnAm.Size = new System.Drawing.Size(86, 68);
            this.btnAm.TabIndex = 161;
            this.btnAm.Text = "+/-";
            this.btnAm.TextColor = System.Drawing.Color.White;
            this.btnAm.UseVisualStyleBackColor = false;
            this.btnAm.Click += new System.EventHandler(this.btnAm_Click);
            // 
            // btnModule
            // 
            this.btnModule.BackColor = System.Drawing.Color.Transparent;
            this.btnModule.BorderColor = System.Drawing.Color.Silver;
            this.btnModule.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnModule.FlatAppearance.BorderSize = 0;
            this.btnModule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule.ForeColor = System.Drawing.Color.Black;
            this.btnModule.Location = new System.Drawing.Point(272, 344);
            this.btnModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModule.Name = "btnModule";
            this.btnModule.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnModule.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnModule.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnModule.Size = new System.Drawing.Size(86, 68);
            this.btnModule.TabIndex = 160;
            this.btnModule.Text = "%";
            this.btnModule.TextColor = System.Drawing.Color.White;
            this.btnModule.UseVisualStyleBackColor = false;
            this.btnModule.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnMu2
            // 
            this.btnMu2.BackColor = System.Drawing.Color.Transparent;
            this.btnMu2.BorderColor = System.Drawing.Color.Silver;
            this.btnMu2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnMu2.FlatAppearance.BorderSize = 0;
            this.btnMu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMu2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMu2.ForeColor = System.Drawing.Color.Black;
            this.btnMu2.Location = new System.Drawing.Point(-1, 640);
            this.btnMu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMu2.Name = "btnMu2";
            this.btnMu2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMu2.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnMu2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnMu2.Size = new System.Drawing.Size(86, 68);
            this.btnMu2.TabIndex = 159;
            this.btnMu2.Text = "x²";
            this.btnMu2.TextColor = System.Drawing.Color.White;
            this.btnMu2.UseVisualStyleBackColor = false;
            this.btnMu2.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.Transparent;
            this.btnPi.BorderColor = System.Drawing.Color.Silver;
            this.btnPi.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnPi.FlatAppearance.BorderSize = 0;
            this.btnPi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.Color.Black;
            this.btnPi.Location = new System.Drawing.Point(-1, 562);
            this.btnPi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPi.Name = "btnPi";
            this.btnPi.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnPi.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnPi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnPi.Size = new System.Drawing.Size(86, 68);
            this.btnPi.TabIndex = 158;
            this.btnPi.Text = "π";
            this.btnPi.TextColor = System.Drawing.Color.White;
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnGiaiThua
            // 
            this.btnGiaiThua.BackColor = System.Drawing.Color.Transparent;
            this.btnGiaiThua.BorderColor = System.Drawing.Color.Silver;
            this.btnGiaiThua.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnGiaiThua.FlatAppearance.BorderSize = 0;
            this.btnGiaiThua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGiaiThua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGiaiThua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaiThua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiThua.ForeColor = System.Drawing.Color.Black;
            this.btnGiaiThua.Location = new System.Drawing.Point(181, 418);
            this.btnGiaiThua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiaiThua.Name = "btnGiaiThua";
            this.btnGiaiThua.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnGiaiThua.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnGiaiThua.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnGiaiThua.Size = new System.Drawing.Size(86, 68);
            this.btnGiaiThua.TabIndex = 156;
            this.btnGiaiThua.Text = "!";
            this.btnGiaiThua.TextColor = System.Drawing.Color.White;
            this.btnGiaiThua.UseVisualStyleBackColor = false;
            this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
            // 
            // btnPhanx
            // 
            this.btnPhanx.BackColor = System.Drawing.Color.Transparent;
            this.btnPhanx.BorderColor = System.Drawing.Color.Silver;
            this.btnPhanx.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnPhanx.FlatAppearance.BorderSize = 0;
            this.btnPhanx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPhanx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPhanx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanx.ForeColor = System.Drawing.Color.Black;
            this.btnPhanx.Location = new System.Drawing.Point(363, 344);
            this.btnPhanx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanx.Name = "btnPhanx";
            this.btnPhanx.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnPhanx.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnPhanx.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnPhanx.Size = new System.Drawing.Size(86, 68);
            this.btnPhanx.TabIndex = 155;
            this.btnPhanx.Text = "1/x";
            this.btnPhanx.TextColor = System.Drawing.Color.White;
            this.btnPhanx.UseVisualStyleBackColor = false;
            this.btnPhanx.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.Color.Transparent;
            this.btnLn.BorderColor = System.Drawing.Color.Silver;
            this.btnLn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnLn.FlatAppearance.BorderSize = 0;
            this.btnLn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.ForeColor = System.Drawing.Color.Black;
            this.btnLn.Location = new System.Drawing.Point(272, 418);
            this.btnLn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLn.Name = "btnLn";
            this.btnLn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLn.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnLn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnLn.Size = new System.Drawing.Size(86, 68);
            this.btnLn.TabIndex = 154;
            this.btnLn.Text = "ln()";
            this.btnLn.TextColor = System.Drawing.Color.White;
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.Transparent;
            this.btnAbs.BorderColor = System.Drawing.Color.Silver;
            this.btnAbs.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAbs.FlatAppearance.BorderSize = 0;
            this.btnAbs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.ForeColor = System.Drawing.Color.Black;
            this.btnAbs.Location = new System.Drawing.Point(90, 418);
            this.btnAbs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAbs.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnAbs.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnAbs.Size = new System.Drawing.Size(86, 68);
            this.btnAbs.TabIndex = 153;
            this.btnAbs.Text = "Abs()";
            this.btnAbs.TextColor = System.Drawing.Color.White;
            this.btnAbs.UseVisualStyleBackColor = false;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.Transparent;
            this.btnSqrt.BorderColor = System.Drawing.Color.Silver;
            this.btnSqrt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.Black;
            this.btnSqrt.Location = new System.Drawing.Point(272, 712);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSqrt.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSqrt.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSqrt.Size = new System.Drawing.Size(86, 68);
            this.btnSqrt.TabIndex = 152;
            this.btnSqrt.Text = "√()";
            this.btnSqrt.TextColor = System.Drawing.Color.White;
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.Color.Transparent;
            this.btnTru.BorderColor = System.Drawing.Color.Silver;
            this.btnTru.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnTru.FlatAppearance.BorderSize = 0;
            this.btnTru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTru.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.ForeColor = System.Drawing.Color.Black;
            this.btnTru.Location = new System.Drawing.Point(363, 490);
            this.btnTru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTru.Name = "btnTru";
            this.btnTru.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTru.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnTru.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnTru.Size = new System.Drawing.Size(86, 68);
            this.btnTru.TabIndex = 151;
            this.btnTru.Text = "-";
            this.btnTru.TextColor = System.Drawing.Color.White;
            this.btnTru.UseVisualStyleBackColor = false;
            this.btnTru.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.Color.Transparent;
            this.btnCong.BorderColor = System.Drawing.Color.Silver;
            this.btnCong.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnCong.FlatAppearance.BorderSize = 0;
            this.btnCong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.ForeColor = System.Drawing.Color.Black;
            this.btnCong.Location = new System.Drawing.Point(363, 418);
            this.btnCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCong.Name = "btnCong";
            this.btnCong.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCong.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnCong.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnCong.Size = new System.Drawing.Size(86, 68);
            this.btnCong.TabIndex = 150;
            this.btnCong.Text = "+";
            this.btnCong.TextColor = System.Drawing.Color.White;
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnChia
            // 
            this.btnChia.BackColor = System.Drawing.Color.Transparent;
            this.btnChia.BorderColor = System.Drawing.Color.Silver;
            this.btnChia.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnChia.FlatAppearance.BorderSize = 0;
            this.btnChia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChia.ForeColor = System.Drawing.Color.Black;
            this.btnChia.Location = new System.Drawing.Point(363, 636);
            this.btnChia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChia.Name = "btnChia";
            this.btnChia.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnChia.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnChia.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnChia.Size = new System.Drawing.Size(86, 68);
            this.btnChia.TabIndex = 149;
            this.btnChia.Text = "/";
            this.btnChia.TextColor = System.Drawing.Color.White;
            this.btnChia.UseVisualStyleBackColor = false;
            this.btnChia.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnNhan.BorderColor = System.Drawing.Color.Silver;
            this.btnNhan.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnNhan.FlatAppearance.BorderSize = 0;
            this.btnNhan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.ForeColor = System.Drawing.Color.Black;
            this.btnNhan.Location = new System.Drawing.Point(363, 559);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnNhan.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnNhan.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnNhan.Size = new System.Drawing.Size(86, 68);
            this.btnNhan.TabIndex = 148;
            this.btnNhan.Text = "x";
            this.btnNhan.TextColor = System.Drawing.Color.White;
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnBang
            // 
            this.btnBang.BackColor = System.Drawing.Color.Transparent;
            this.btnBang.BorderColor = System.Drawing.Color.Silver;
            this.btnBang.ButtonColor = System.Drawing.Color.RosyBrown;
            this.btnBang.FlatAppearance.BorderSize = 0;
            this.btnBang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBang.ForeColor = System.Drawing.Color.Black;
            this.btnBang.Location = new System.Drawing.Point(363, 712);
            this.btnBang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBang.Name = "btnBang";
            this.btnBang.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnBang.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnBang.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnBang.Size = new System.Drawing.Size(86, 68);
            this.btnBang.TabIndex = 147;
            this.btnBang.Text = "=";
            this.btnBang.TextColor = System.Drawing.Color.White;
            this.btnBang.UseVisualStyleBackColor = false;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // btnSo0
            // 
            this.btnSo0.BackColor = System.Drawing.Color.Transparent;
            this.btnSo0.BorderColor = System.Drawing.Color.Silver;
            this.btnSo0.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo0.FlatAppearance.BorderSize = 0;
            this.btnSo0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo0.ForeColor = System.Drawing.Color.Black;
            this.btnSo0.Location = new System.Drawing.Point(181, 712);
            this.btnSo0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo0.Name = "btnSo0";
            this.btnSo0.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo0.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo0.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo0.Size = new System.Drawing.Size(86, 68);
            this.btnSo0.TabIndex = 146;
            this.btnSo0.Text = "0";
            this.btnSo0.TextColor = System.Drawing.Color.White;
            this.btnSo0.UseVisualStyleBackColor = false;
            this.btnSo0.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnCham
            // 
            this.btnCham.BackColor = System.Drawing.Color.Transparent;
            this.btnCham.BorderColor = System.Drawing.Color.Silver;
            this.btnCham.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnCham.FlatAppearance.BorderSize = 0;
            this.btnCham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCham.ForeColor = System.Drawing.Color.Black;
            this.btnCham.Location = new System.Drawing.Point(90, 712);
            this.btnCham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCham.Name = "btnCham";
            this.btnCham.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCham.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnCham.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnCham.Size = new System.Drawing.Size(86, 68);
            this.btnCham.TabIndex = 145;
            this.btnCham.Text = ".";
            this.btnCham.TextColor = System.Drawing.Color.White;
            this.btnCham.UseVisualStyleBackColor = false;
            this.btnCham.Click += new System.EventHandler(this.btnCham_Click);
            // 
            // btnSo4
            // 
            this.btnSo4.BackColor = System.Drawing.Color.Transparent;
            this.btnSo4.BorderColor = System.Drawing.Color.Silver;
            this.btnSo4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo4.FlatAppearance.BorderSize = 0;
            this.btnSo4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo4.ForeColor = System.Drawing.Color.Black;
            this.btnSo4.Location = new System.Drawing.Point(90, 562);
            this.btnSo4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo4.Name = "btnSo4";
            this.btnSo4.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo4.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo4.Size = new System.Drawing.Size(86, 68);
            this.btnSo4.TabIndex = 144;
            this.btnSo4.Text = "4";
            this.btnSo4.TextColor = System.Drawing.Color.White;
            this.btnSo4.UseVisualStyleBackColor = false;
            this.btnSo4.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSo5
            // 
            this.btnSo5.BackColor = System.Drawing.Color.Transparent;
            this.btnSo5.BorderColor = System.Drawing.Color.Silver;
            this.btnSo5.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo5.FlatAppearance.BorderSize = 0;
            this.btnSo5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo5.ForeColor = System.Drawing.Color.Black;
            this.btnSo5.Location = new System.Drawing.Point(181, 562);
            this.btnSo5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo5.Name = "btnSo5";
            this.btnSo5.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo5.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo5.Size = new System.Drawing.Size(86, 68);
            this.btnSo5.TabIndex = 143;
            this.btnSo5.Text = "5";
            this.btnSo5.TextColor = System.Drawing.Color.White;
            this.btnSo5.UseVisualStyleBackColor = false;
            this.btnSo5.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSo6
            // 
            this.btnSo6.BackColor = System.Drawing.Color.Transparent;
            this.btnSo6.BorderColor = System.Drawing.Color.Silver;
            this.btnSo6.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo6.FlatAppearance.BorderSize = 0;
            this.btnSo6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo6.ForeColor = System.Drawing.Color.Black;
            this.btnSo6.Location = new System.Drawing.Point(272, 562);
            this.btnSo6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo6.Name = "btnSo6";
            this.btnSo6.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo6.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo6.Size = new System.Drawing.Size(86, 68);
            this.btnSo6.TabIndex = 142;
            this.btnSo6.Text = "6";
            this.btnSo6.TextColor = System.Drawing.Color.White;
            this.btnSo6.UseVisualStyleBackColor = false;
            this.btnSo6.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSo7
            // 
            this.btnSo7.BackColor = System.Drawing.Color.Transparent;
            this.btnSo7.BorderColor = System.Drawing.Color.Silver;
            this.btnSo7.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo7.FlatAppearance.BorderSize = 0;
            this.btnSo7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo7.ForeColor = System.Drawing.Color.Black;
            this.btnSo7.Location = new System.Drawing.Point(90, 490);
            this.btnSo7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo7.Name = "btnSo7";
            this.btnSo7.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo7.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo7.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo7.Size = new System.Drawing.Size(86, 68);
            this.btnSo7.TabIndex = 141;
            this.btnSo7.Text = "7";
            this.btnSo7.TextColor = System.Drawing.Color.White;
            this.btnSo7.UseVisualStyleBackColor = false;
            this.btnSo7.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSo8
            // 
            this.btnSo8.BackColor = System.Drawing.Color.Transparent;
            this.btnSo8.BorderColor = System.Drawing.Color.Silver;
            this.btnSo8.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo8.FlatAppearance.BorderSize = 0;
            this.btnSo8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo8.ForeColor = System.Drawing.Color.Black;
            this.btnSo8.Location = new System.Drawing.Point(181, 490);
            this.btnSo8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo8.Name = "btnSo8";
            this.btnSo8.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo8.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo8.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo8.Size = new System.Drawing.Size(86, 68);
            this.btnSo8.TabIndex = 140;
            this.btnSo8.Text = "8";
            this.btnSo8.TextColor = System.Drawing.Color.White;
            this.btnSo8.UseVisualStyleBackColor = false;
            this.btnSo8.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSo9
            // 
            this.btnSo9.BackColor = System.Drawing.Color.Transparent;
            this.btnSo9.BorderColor = System.Drawing.Color.Silver;
            this.btnSo9.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo9.FlatAppearance.BorderSize = 0;
            this.btnSo9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo9.ForeColor = System.Drawing.Color.Black;
            this.btnSo9.Location = new System.Drawing.Point(272, 490);
            this.btnSo9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo9.Name = "btnSo9";
            this.btnSo9.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo9.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo9.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo9.Size = new System.Drawing.Size(86, 68);
            this.btnSo9.TabIndex = 139;
            this.btnSo9.Text = "9";
            this.btnSo9.TextColor = System.Drawing.Color.White;
            this.btnSo9.UseVisualStyleBackColor = false;
            this.btnSo9.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSo3
            // 
            this.btnSo3.BackColor = System.Drawing.Color.Transparent;
            this.btnSo3.BorderColor = System.Drawing.Color.Silver;
            this.btnSo3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo3.FlatAppearance.BorderSize = 0;
            this.btnSo3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo3.ForeColor = System.Drawing.Color.Black;
            this.btnSo3.Location = new System.Drawing.Point(272, 640);
            this.btnSo3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo3.Name = "btnSo3";
            this.btnSo3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo3.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo3.Size = new System.Drawing.Size(86, 68);
            this.btnSo3.TabIndex = 138;
            this.btnSo3.Text = "3";
            this.btnSo3.TextColor = System.Drawing.Color.White;
            this.btnSo3.UseVisualStyleBackColor = false;
            this.btnSo3.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSo2
            // 
            this.btnSo2.BackColor = System.Drawing.Color.Transparent;
            this.btnSo2.BorderColor = System.Drawing.Color.Silver;
            this.btnSo2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo2.FlatAppearance.BorderSize = 0;
            this.btnSo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo2.ForeColor = System.Drawing.Color.Black;
            this.btnSo2.Location = new System.Drawing.Point(181, 640);
            this.btnSo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo2.Name = "btnSo2";
            this.btnSo2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo2.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo2.Size = new System.Drawing.Size(86, 68);
            this.btnSo2.TabIndex = 137;
            this.btnSo2.Text = "2";
            this.btnSo2.TextColor = System.Drawing.Color.White;
            this.btnSo2.UseVisualStyleBackColor = false;
            this.btnSo2.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSo1
            // 
            this.btnSo1.BackColor = System.Drawing.Color.Transparent;
            this.btnSo1.BorderColor = System.Drawing.Color.Silver;
            this.btnSo1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSo1.FlatAppearance.BorderSize = 0;
            this.btnSo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo1.ForeColor = System.Drawing.Color.Black;
            this.btnSo1.Location = new System.Drawing.Point(90, 640);
            this.btnSo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSo1.Name = "btnSo1";
            this.btnSo1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSo1.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.btnSo1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSo1.Size = new System.Drawing.Size(86, 68);
            this.btnSo1.TabIndex = 136;
            this.btnSo1.Text = "1";
            this.btnSo1.TextColor = System.Drawing.Color.White;
            this.btnSo1.UseVisualStyleBackColor = false;
            this.btnSo1.Click += new System.EventHandler(this.btnSo0_Click);
            // 
            // btnSang
            // 
            this.btnSang.BorderColor = System.Drawing.Color.Orange;
            this.btnSang.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSang.FlatAppearance.BorderSize = 0;
            this.btnSang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSang.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSang.Location = new System.Drawing.Point(6, 11);
            this.btnSang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSang.Name = "btnSang";
            this.btnSang.OnHoverBorderColor = System.Drawing.Color.Wheat;
            this.btnSang.OnHoverButtonColor = System.Drawing.Color.IndianRed;
            this.btnSang.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnSang.Size = new System.Drawing.Size(82, 68);
            this.btnSang.TabIndex = 184;
            this.btnSang.Text = "☾";
            this.btnSang.TextColor = System.Drawing.Color.White;
            this.btnSang.UseVisualStyleBackColor = true;
            this.btnSang.Click += new System.EventHandler(this.btSang_Click);
            // 
            // btnToi
            // 
            this.btnToi.BorderColor = System.Drawing.Color.Orange;
            this.btnToi.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnToi.FlatAppearance.BorderSize = 0;
            this.btnToi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnToi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnToi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToi.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToi.Location = new System.Drawing.Point(6, 11);
            this.btnToi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToi.Name = "btnToi";
            this.btnToi.OnHoverBorderColor = System.Drawing.Color.Wheat;
            this.btnToi.OnHoverButtonColor = System.Drawing.Color.IndianRed;
            this.btnToi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnToi.Size = new System.Drawing.Size(82, 68);
            this.btnToi.TabIndex = 183;
            this.btnToi.Text = "◗";
            this.btnToi.TextColor = System.Drawing.Color.White;
            this.btnToi.UseVisualStyleBackColor = true;
            this.btnToi.Click += new System.EventHandler(this.btSang_Click);
            // 
            // btnCalender
            // 
            this.btnCalender.BorderColor = System.Drawing.Color.Orange;
            this.btnCalender.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnCalender.FlatAppearance.BorderSize = 0;
            this.btnCalender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalender.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnCalender.Location = new System.Drawing.Point(93, 11);
            this.btnCalender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.OnHoverBorderColor = System.Drawing.Color.Wheat;
            this.btnCalender.OnHoverButtonColor = System.Drawing.Color.IndianRed;
            this.btnCalender.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnCalender.Size = new System.Drawing.Size(82, 68);
            this.btnCalender.TabIndex = 182;
            this.btnCalender.Text = "2";
            this.btnCalender.TextColor = System.Drawing.Color.White;
            this.btnCalender.UseVisualStyleBackColor = true;
            this.btnCalender.Click += new System.EventHandler(this.btnCalender_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.BorderColor = System.Drawing.Color.Orange;
            this.btnStandard.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnStandard.FlatAppearance.BorderSize = 0;
            this.btnStandard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStandard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandard.Location = new System.Drawing.Point(181, 11);
            this.btnStandard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.OnHoverBorderColor = System.Drawing.Color.Wheat;
            this.btnStandard.OnHoverButtonColor = System.Drawing.Color.IndianRed;
            this.btnStandard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnStandard.Size = new System.Drawing.Size(82, 68);
            this.btnStandard.TabIndex = 181;
            this.btnStandard.Text = "Standar";
            this.btnStandard.TextColor = System.Drawing.Color.White;
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // FrmSci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(454, 844);
            this.Controls.Add(this.btnSang);
            this.Controls.Add(this.btnToi);
            this.Controls.Add(this.btnCalender);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.btHistory);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.btn10Mux);
            this.Controls.Add(this.btnxMuy);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnAm);
            this.Controls.Add(this.btnModule);
            this.Controls.Add(this.btnMu2);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnGiaiThua);
            this.Controls.Add(this.btnPhanx);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btnSo0);
            this.Controls.Add(this.btnCham);
            this.Controls.Add(this.btnSo4);
            this.Controls.Add(this.btnSo5);
            this.Controls.Add(this.btnSo6);
            this.Controls.Add(this.btnSo7);
            this.Controls.Add(this.btnSo8);
            this.Controls.Add(this.btnSo9);
            this.Controls.Add(this.btnSo3);
            this.Controls.Add(this.btnSo2);
            this.Controls.Add(this.btnSo1);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.txtODuLieu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(476, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 800);
            this.Name = "FrmSci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Science Calculator";
            this.Load += new System.EventHandler(this.FrmSci_Load);
            this.pnlHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtODuLieu;
        private System.Windows.Forms.Timer timer1;
        private ePOSOne.btnProduct.Button_WOC btnSo1;
        private ePOSOne.btnProduct.Button_WOC btnSo2;
        private ePOSOne.btnProduct.Button_WOC btnSo3;
        private ePOSOne.btnProduct.Button_WOC btnSo9;
        private ePOSOne.btnProduct.Button_WOC btnSo8;
        private ePOSOne.btnProduct.Button_WOC btnSo7;
        private ePOSOne.btnProduct.Button_WOC btnSo6;
        private ePOSOne.btnProduct.Button_WOC btnSo5;
        private ePOSOne.btnProduct.Button_WOC btnSo4;
        private ePOSOne.btnProduct.Button_WOC btnCham;
        private ePOSOne.btnProduct.Button_WOC btnSo0;
        private ePOSOne.btnProduct.Button_WOC btnBang;
        private ePOSOne.btnProduct.Button_WOC btnNhan;
        private ePOSOne.btnProduct.Button_WOC btnChia;
        private ePOSOne.btnProduct.Button_WOC btnCong;
        private ePOSOne.btnProduct.Button_WOC btnTru;
        private ePOSOne.btnProduct.Button_WOC btnSqrt;
        private ePOSOne.btnProduct.Button_WOC btnAbs;
        private ePOSOne.btnProduct.Button_WOC btnLn;
        private ePOSOne.btnProduct.Button_WOC btnPhanx;
        private ePOSOne.btnProduct.Button_WOC btnGiaiThua;
        private ePOSOne.btnProduct.Button_WOC btnPi;
        private ePOSOne.btnProduct.Button_WOC btnMu2;
        private ePOSOne.btnProduct.Button_WOC btnModule;
        private ePOSOne.btnProduct.Button_WOC btnAm;
        private ePOSOne.btnProduct.Button_WOC btnE;
        private ePOSOne.btnProduct.Button_WOC btnClear;
        private ePOSOne.btnProduct.Button_WOC btnDel;
        private ePOSOne.btnProduct.Button_WOC btnxMuy;
        private ePOSOne.btnProduct.Button_WOC btn10Mux;
        private System.Windows.Forms.Button btHistory;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button btDelHistory;
        private ePOSOne.btnProduct.Button_WOC btnSang;
        private ePOSOne.btnProduct.Button_WOC btnToi;
        private ePOSOne.btnProduct.Button_WOC btnCalender;
        private ePOSOne.btnProduct.Button_WOC btnStandard;
    }
}