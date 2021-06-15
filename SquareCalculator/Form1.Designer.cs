
namespace SquareCalculator
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_startAt = new System.Windows.Forms.TextBox();
            this.txt_endAt = new System.Windows.Forms.TextBox();
            this.lbl_startAt = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(61, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(663, 277);
            this.listBox1.TabIndex = 0;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(532, 25);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(138, 77);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_startAt
            // 
            this.txt_startAt.Location = new System.Drawing.Point(199, 31);
            this.txt_startAt.Name = "txt_startAt";
            this.txt_startAt.Size = new System.Drawing.Size(91, 20);
            this.txt_startAt.TabIndex = 2;
            // 
            // txt_endAt
            // 
            this.txt_endAt.Location = new System.Drawing.Point(199, 78);
            this.txt_endAt.Name = "txt_endAt";
            this.txt_endAt.Size = new System.Drawing.Size(91, 20);
            this.txt_endAt.TabIndex = 3;
            // 
            // lbl_startAt
            // 
            this.lbl_startAt.AutoSize = true;
            this.lbl_startAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_startAt.ForeColor = System.Drawing.Color.Coral;
            this.lbl_startAt.Location = new System.Drawing.Point(95, 31);
            this.lbl_startAt.Name = "lbl_startAt";
            this.lbl_startAt.Size = new System.Drawing.Size(70, 24);
            this.lbl_startAt.TabIndex = 4;
            this.lbl_startAt.Text = "Start at:";
            this.lbl_startAt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_end.ForeColor = System.Drawing.Color.Coral;
            this.lbl_end.Location = new System.Drawing.Point(96, 78);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(69, 24);
            this.lbl_end.TabIndex = 5;
            this.lbl_end.Text = "End at:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_startAt);
            this.Controls.Add(this.txt_endAt);
            this.Controls.Add(this.txt_startAt);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_startAt;
        private System.Windows.Forms.TextBox txt_endAt;
        private System.Windows.Forms.Label lbl_startAt;
        private System.Windows.Forms.Label lbl_end;
    }
}

