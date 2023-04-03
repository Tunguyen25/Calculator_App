namespace Caculator
{
    partial class CalenderCalcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalenderCalcs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.btnDifference = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbResult1 = new System.Windows.Forms.Label();
            this.btnScience = new ePOSOne.btnProduct.Button_WOC();
            this.btnStandard = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // fromDate
            // 
            this.fromDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Location = new System.Drawing.Point(9, 44);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(410, 35);
            this.fromDate.TabIndex = 2;
            // 
            // toDate
            // 
            this.toDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Location = new System.Drawing.Point(9, 141);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(410, 35);
            this.toDate.TabIndex = 3;
            // 
            // btnDifference
            // 
            this.btnDifference.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDifference.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDifference.Location = new System.Drawing.Point(134, 206);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(147, 47);
            this.btnDifference.TabIndex = 4;
            this.btnDifference.Text = "Difference";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(8, 256);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(264, 42);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "label3";
            // 
            // lbResult1
            // 
            this.lbResult1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult1.Location = new System.Drawing.Point(8, 298);
            this.lbResult1.Name = "lbResult1";
            this.lbResult1.Size = new System.Drawing.Size(273, 143);
            this.lbResult1.TabIndex = 6;
            this.lbResult1.Text = "label3";
            // 
            // btnScience
            // 
            this.btnScience.BorderColor = System.Drawing.Color.Orange;
            this.btnScience.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnScience.FlatAppearance.BorderSize = 0;
            this.btnScience.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScience.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnScience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScience.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScience.Location = new System.Drawing.Point(0, 382);
            this.btnScience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScience.Name = "btnScience";
            this.btnScience.OnHoverBorderColor = System.Drawing.Color.Wheat;
            this.btnScience.OnHoverButtonColor = System.Drawing.Color.IndianRed;
            this.btnScience.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnScience.Size = new System.Drawing.Size(95, 68);
            this.btnScience.TabIndex = 183;
            this.btnScience.Text = "Science";
            this.btnScience.TextColor = System.Drawing.Color.Black;
            this.btnScience.UseVisualStyleBackColor = true;
            this.btnScience.Click += new System.EventHandler(this.btnSci_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.BorderColor = System.Drawing.Color.Orange;
            this.btnStandard.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnStandard.FlatAppearance.BorderSize = 0;
            this.btnStandard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStandard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandard.Location = new System.Drawing.Point(338, 382);
            this.btnStandard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.OnHoverBorderColor = System.Drawing.Color.Wheat;
            this.btnStandard.OnHoverButtonColor = System.Drawing.Color.IndianRed;
            this.btnStandard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(26)))));
            this.btnStandard.Size = new System.Drawing.Size(95, 68);
            this.btnStandard.TabIndex = 182;
            this.btnStandard.Text = "Standar";
            this.btnStandard.TextColor = System.Drawing.Color.Black;
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // CalenderCalcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(431, 453);
            this.Controls.Add(this.btnScience);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.lbResult1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnDifference);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 509);
            this.MinimizeBox = false;
            this.Name = "CalenderCalcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calender Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbResult1;
        private ePOSOne.btnProduct.Button_WOC btnStandard;
        private ePOSOne.btnProduct.Button_WOC btnScience;
    }
}