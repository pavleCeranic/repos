
namespace ShipCargoWinForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_cycleCount = new System.Windows.Forms.Label();
            this.label_trucksCount = new System.Windows.Forms.Label();
            this.label_trainsCount = new System.Windows.Forms.Label();
            this.label_carsCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tracks_trains = new System.Windows.Forms.TrackBar();
            this.track_cars = new System.Windows.Forms.TrackBar();
            this.track_motorCycles = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.label_shipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracks_trains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Ship";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motor Cycles(3 units)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trucks(11 units)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cars(5 units)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Train(17 units)";
            // 
            // label_cycleCount
            // 
            this.label_cycleCount.AutoSize = true;
            this.label_cycleCount.Location = new System.Drawing.Point(97, 245);
            this.label_cycleCount.Name = "label_cycleCount";
            this.label_cycleCount.Size = new System.Drawing.Size(35, 13);
            this.label_cycleCount.TabIndex = 5;
            this.label_cycleCount.Text = "label5";
            // 
            // label_trucksCount
            // 
            this.label_trucksCount.AutoSize = true;
            this.label_trucksCount.Location = new System.Drawing.Point(593, 245);
            this.label_trucksCount.Name = "label_trucksCount";
            this.label_trucksCount.Size = new System.Drawing.Size(35, 13);
            this.label_trucksCount.TabIndex = 6;
            this.label_trucksCount.Text = "label6";
            // 
            // label_trainsCount
            // 
            this.label_trainsCount.AutoSize = true;
            this.label_trainsCount.Location = new System.Drawing.Point(593, 366);
            this.label_trainsCount.Name = "label_trainsCount";
            this.label_trainsCount.Size = new System.Drawing.Size(35, 13);
            this.label_trainsCount.TabIndex = 7;
            this.label_trainsCount.Text = "label7";
            // 
            // label_carsCount
            // 
            this.label_carsCount.AutoSize = true;
            this.label_carsCount.Location = new System.Drawing.Point(97, 366);
            this.label_carsCount.Name = "label_carsCount";
            this.label_carsCount.Size = new System.Drawing.Size(35, 13);
            this.label_carsCount.TabIndex = 8;
            this.label_carsCount.Text = "label8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShipCargoWinForms.Properties.Resources.cargoship;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(158, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(563, 92);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 45;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // tracks_trains
            // 
            this.tracks_trains.Location = new System.Drawing.Point(468, 382);
            this.tracks_trains.Name = "tracks_trains";
            this.tracks_trains.Size = new System.Drawing.Size(253, 45);
            this.tracks_trains.TabIndex = 11;
            this.tracks_trains.Scroll += new System.EventHandler(this.tracks_trains_Scroll);
            // 
            // track_cars
            // 
            this.track_cars.Location = new System.Drawing.Point(17, 382);
            this.track_cars.Name = "track_cars";
            this.track_cars.Size = new System.Drawing.Size(253, 45);
            this.track_cars.TabIndex = 12;
            this.track_cars.Scroll += new System.EventHandler(this.track_cars_Scroll);
            // 
            // track_motorCycles
            // 
            this.track_motorCycles.Location = new System.Drawing.Point(17, 261);
            this.track_motorCycles.Name = "track_motorCycles";
            this.track_motorCycles.Size = new System.Drawing.Size(253, 45);
            this.track_motorCycles.TabIndex = 13;
            this.track_motorCycles.Scroll += new System.EventHandler(this.track_motorCycles_Scroll);
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(468, 261);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(253, 45);
            this.track_trucks.TabIndex = 14;
            this.track_trucks.Scroll += new System.EventHandler(this.track_trucks_Scroll);
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Location = new System.Drawing.Point(189, 151);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(35, 13);
            this.label_shipLabel.TabIndex = 15;
            this.label_shipLabel.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 544);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_motorCycles);
            this.Controls.Add(this.track_cars);
            this.Controls.Add(this.tracks_trains);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_carsCount);
            this.Controls.Add(this.label_trainsCount);
            this.Controls.Add(this.label_trucksCount);
            this.Controls.Add(this.label_cycleCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Load the Ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracks_trains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label_trucksCount;
        private System.Windows.Forms.Label label_trainsCount;
        private System.Windows.Forms.Label label_carsCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar tracks_trains;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_motorCycles;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.Label label_shipLabel;
    }
}

