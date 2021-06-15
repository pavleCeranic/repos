
namespace HelloWorldWinForms
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
            this.btn_addFriend = new System.Windows.Forms.Button();
            this.txt_newFriend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addFive = new System.Windows.Forms.Button();
            this.btn_sortAscending = new System.Windows.Forms.Button();
            this.btn_sortDescending = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 459);
            this.listBox1.TabIndex = 0;
            // 
            // btn_addFriend
            // 
            this.btn_addFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_addFriend.Location = new System.Drawing.Point(241, 80);
            this.btn_addFriend.Name = "btn_addFriend";
            this.btn_addFriend.Size = new System.Drawing.Size(120, 32);
            this.btn_addFriend.TabIndex = 1;
            this.btn_addFriend.Text = "Add Friend";
            this.btn_addFriend.UseVisualStyleBackColor = true;
            this.btn_addFriend.Click += new System.EventHandler(this.btn_addFriend_Click);
            // 
            // txt_newFriend
            // 
            this.txt_newFriend.Location = new System.Drawing.Point(241, 28);
            this.txt_newFriend.Name = "txt_newFriend";
            this.txt_newFriend.Size = new System.Drawing.Size(271, 20);
            this.txt_newFriend.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(392, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_addFive
            // 
            this.btn_addFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_addFive.Location = new System.Drawing.Point(241, 137);
            this.btn_addFive.Name = "btn_addFive";
            this.btn_addFive.Size = new System.Drawing.Size(120, 32);
            this.btn_addFive.TabIndex = 4;
            this.btn_addFive.Text = "Add 5 Friends";
            this.btn_addFive.UseVisualStyleBackColor = true;
            this.btn_addFive.Click += new System.EventHandler(this.btn_addFive_Click);
            // 
            // btn_sortAscending
            // 
            this.btn_sortAscending.Location = new System.Drawing.Point(241, 425);
            this.btn_sortAscending.Name = "btn_sortAscending";
            this.btn_sortAscending.Size = new System.Drawing.Size(120, 46);
            this.btn_sortAscending.TabIndex = 5;
            this.btn_sortAscending.Text = "A-Z";
            this.btn_sortAscending.UseVisualStyleBackColor = true;
            this.btn_sortAscending.Click += new System.EventHandler(this.btn_sortAscending_Click);
            // 
            // btn_sortDescending
            // 
            this.btn_sortDescending.Location = new System.Drawing.Point(380, 425);
            this.btn_sortDescending.Name = "btn_sortDescending";
            this.btn_sortDescending.Size = new System.Drawing.Size(120, 46);
            this.btn_sortDescending.TabIndex = 6;
            this.btn_sortDescending.Text = "Z-A";
            this.btn_sortDescending.UseVisualStyleBackColor = true;
            this.btn_sortDescending.Click += new System.EventHandler(this.btn_sortDescending_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(519, 425);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 46);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(651, 482);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sortDescending);
            this.Controls.Add(this.btn_sortAscending);
            this.Controls.Add(this.btn_addFive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_newFriend);
            this.Controls.Add(this.btn_addFriend);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "My Frineds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Label lbl_hellomessage;
        private System.Windows.Forms.Button btn_changecolor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_addFriend;
        private System.Windows.Forms.TextBox txt_newFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addFive;
        private System.Windows.Forms.Button btn_sortAscending;
        private System.Windows.Forms.Button btn_sortDescending;
        private System.Windows.Forms.Button btn_clear;
    }
}

