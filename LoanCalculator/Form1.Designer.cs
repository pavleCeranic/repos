
namespace LoanCalculator
{
    partial class Form1
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
            this.lbl_startingBalance = new System.Windows.Forms.Label();
            this.lbl_numberOfMonths = new System.Windows.Forms.Label();
            this.lbl_interestRate = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_startingBalance = new System.Windows.Forms.TextBox();
            this.txt_numberOfMonths = new System.Windows.Forms.TextBox();
            this.txt_interestRate = new System.Windows.Forms.TextBox();
            this.lbl_endingBalance = new System.Windows.Forms.Label();
            this.txt_endingBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_startingBalance
            // 
            this.lbl_startingBalance.AutoSize = true;
            this.lbl_startingBalance.Location = new System.Drawing.Point(143, 39);
            this.lbl_startingBalance.Name = "lbl_startingBalance";
            this.lbl_startingBalance.Size = new System.Drawing.Size(85, 13);
            this.lbl_startingBalance.TabIndex = 0;
            this.lbl_startingBalance.Text = "Starting Balance";
            // 
            // lbl_numberOfMonths
            // 
            this.lbl_numberOfMonths.AutoSize = true;
            this.lbl_numberOfMonths.Location = new System.Drawing.Point(143, 74);
            this.lbl_numberOfMonths.Name = "lbl_numberOfMonths";
            this.lbl_numberOfMonths.Size = new System.Drawing.Size(96, 13);
            this.lbl_numberOfMonths.TabIndex = 1;
            this.lbl_numberOfMonths.Text = "Number Of Months";
            // 
            // lbl_interestRate
            // 
            this.lbl_interestRate.AutoSize = true;
            this.lbl_interestRate.Location = new System.Drawing.Point(143, 109);
            this.lbl_interestRate.Name = "lbl_interestRate";
            this.lbl_interestRate.Size = new System.Drawing.Size(68, 13);
            this.lbl_interestRate.TabIndex = 2;
            this.lbl_interestRate.Text = "Interest Rate";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(39, 398);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 3;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(184, 398);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(329, 398);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(727, 134);
            this.listBox1.TabIndex = 6;
            // 
            // txt_startingBalance
            // 
            this.txt_startingBalance.Location = new System.Drawing.Point(276, 39);
            this.txt_startingBalance.Name = "txt_startingBalance";
            this.txt_startingBalance.Size = new System.Drawing.Size(129, 20);
            this.txt_startingBalance.TabIndex = 7;
            // 
            // txt_numberOfMonths
            // 
            this.txt_numberOfMonths.Location = new System.Drawing.Point(276, 74);
            this.txt_numberOfMonths.Name = "txt_numberOfMonths";
            this.txt_numberOfMonths.Size = new System.Drawing.Size(130, 20);
            this.txt_numberOfMonths.TabIndex = 8;
            // 
            // txt_interestRate
            // 
            this.txt_interestRate.Location = new System.Drawing.Point(276, 109);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(130, 20);
            this.txt_interestRate.TabIndex = 9;
            // 
            // lbl_endingBalance
            // 
            this.lbl_endingBalance.AutoSize = true;
            this.lbl_endingBalance.Location = new System.Drawing.Point(143, 331);
            this.lbl_endingBalance.Name = "lbl_endingBalance";
            this.lbl_endingBalance.Size = new System.Drawing.Size(82, 13);
            this.lbl_endingBalance.TabIndex = 10;
            this.lbl_endingBalance.Text = "Ending Balance";
            this.lbl_endingBalance.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_endingBalance
            // 
            this.txt_endingBalance.Location = new System.Drawing.Point(255, 331);
            this.txt_endingBalance.Name = "txt_endingBalance";
            this.txt_endingBalance.ReadOnly = true;
            this.txt_endingBalance.Size = new System.Drawing.Size(163, 20);
            this.txt_endingBalance.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_endingBalance);
            this.Controls.Add(this.lbl_endingBalance);
            this.Controls.Add(this.txt_interestRate);
            this.Controls.Add(this.txt_numberOfMonths);
            this.Controls.Add(this.txt_startingBalance);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_interestRate);
            this.Controls.Add(this.lbl_numberOfMonths);
            this.Controls.Add(this.lbl_startingBalance);
            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_startingBalance;
        private System.Windows.Forms.Label lbl_numberOfMonths;
        private System.Windows.Forms.Label lbl_interestRate;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_startingBalance;
        private System.Windows.Forms.TextBox txt_numberOfMonths;
        private System.Windows.Forms.TextBox txt_interestRate;
        private System.Windows.Forms.Label lbl_endingBalance;
        private System.Windows.Forms.TextBox txt_endingBalance;
    }
}

