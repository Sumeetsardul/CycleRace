namespace RacetrackSimulator
{
    partial class CycleRace
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
            this.gamble = new System.Windows.Forms.GroupBox();
            this.Go_button = new System.Windows.Forms.Button();
            this.MalkeetBetLabel = new System.Windows.Forms.Label();
            this.GillBetLabel = new System.Windows.Forms.Label();
            this.SimerBetLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WinnerCycle = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GambleAmt = new System.Windows.Forms.NumericUpDown();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MalkeetRadioButton = new System.Windows.Forms.RadioButton();
            this.GillRadioButton = new System.Windows.Forms.RadioButton();
            this.SimerRadioButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cycle4PB = new System.Windows.Forms.PictureBox();
            this.cycle3PB = new System.Windows.Forms.PictureBox();
            this.cycle2PB = new System.Windows.Forms.PictureBox();
            this.cycle1PB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gamble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GambleAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cycle4PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle3PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle2PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gamble
            // 
            this.gamble.Controls.Add(this.Go_button);
            this.gamble.Controls.Add(this.MalkeetBetLabel);
            this.gamble.Controls.Add(this.GillBetLabel);
            this.gamble.Controls.Add(this.SimerBetLabel);
            this.gamble.Controls.Add(this.label3);
            this.gamble.Controls.Add(this.WinnerCycle);
            this.gamble.Controls.Add(this.label2);
            this.gamble.Controls.Add(this.GambleAmt);
            this.gamble.Controls.Add(this.PlaceBet);
            this.gamble.Controls.Add(this.NameLabel);
            this.gamble.Controls.Add(this.MalkeetRadioButton);
            this.gamble.Controls.Add(this.GillRadioButton);
            this.gamble.Controls.Add(this.SimerRadioButton);
            this.gamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamble.Location = new System.Drawing.Point(11, 521);
            this.gamble.Margin = new System.Windows.Forms.Padding(2);
            this.gamble.Name = "gamble";
            this.gamble.Padding = new System.Windows.Forms.Padding(2);
            this.gamble.Size = new System.Drawing.Size(1082, 193);
            this.gamble.TabIndex = 0;
            this.gamble.TabStop = false;
            this.gamble.Text = "BetHere";
            // 
            // Go_button
            // 
            this.Go_button.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_button.Location = new System.Drawing.Point(836, 41);
            this.Go_button.Margin = new System.Windows.Forms.Padding(2);
            this.Go_button.Name = "Go_button";
            this.Go_button.Size = new System.Drawing.Size(233, 96);
            this.Go_button.TabIndex = 13;
            this.Go_button.Text = "Start";
            this.Go_button.UseVisualStyleBackColor = true;
            this.Go_button.Click += new System.EventHandler(this.Start_Click);
            // 
            // MalkeetBetLabel
            // 
            this.MalkeetBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MalkeetBetLabel.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MalkeetBetLabel.Location = new System.Drawing.Point(701, 140);
            this.MalkeetBetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MalkeetBetLabel.Name = "MalkeetBetLabel";
            this.MalkeetBetLabel.Size = new System.Drawing.Size(348, 33);
            this.MalkeetBetLabel.TabIndex = 12;
            this.MalkeetBetLabel.Text = "MalkeetBetLabel";
            this.MalkeetBetLabel.Click += new System.EventHandler(this.MalkeetBetLabel_Click);
            // 
            // GillBetLabel
            // 
            this.GillBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GillBetLabel.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GillBetLabel.Location = new System.Drawing.Point(344, 140);
            this.GillBetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GillBetLabel.Name = "GillBetLabel";
            this.GillBetLabel.Size = new System.Drawing.Size(353, 32);
            this.GillBetLabel.TabIndex = 11;
            this.GillBetLabel.Text = "GillBetLabel";
            // 
            // SimerBetLabel
            // 
            this.SimerBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimerBetLabel.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimerBetLabel.Location = new System.Drawing.Point(8, 140);
            this.SimerBetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SimerBetLabel.Name = "SimerBetLabel";
            this.SimerBetLabel.Size = new System.Drawing.Size(332, 32);
            this.SimerBetLabel.TabIndex = 10;
            this.SimerBetLabel.Text = "SimerBetLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // WinnerCycle
            // 
            this.WinnerCycle.Location = new System.Drawing.Point(740, 45);
            this.WinnerCycle.Margin = new System.Windows.Forms.Padding(2);
            this.WinnerCycle.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.WinnerCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WinnerCycle.Name = "WinnerCycle";
            this.WinnerCycle.Size = new System.Drawing.Size(38, 23);
            this.WinnerCycle.TabIndex = 8;
            this.WinnerCycle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "$ on Cycle number";
            // 
            // GambleAmt
            // 
            this.GambleAmt.Location = new System.Drawing.Point(523, 47);
            this.GambleAmt.Margin = new System.Windows.Forms.Padding(2);
            this.GambleAmt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GambleAmt.Name = "GambleAmt";
            this.GambleAmt.Size = new System.Drawing.Size(47, 23);
            this.GambleAmt.TabIndex = 6;
            this.GambleAmt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PlaceBet
            // 
            this.PlaceBet.Location = new System.Drawing.Point(432, 44);
            this.PlaceBet.Margin = new System.Windows.Forms.Padding(2);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(56, 27);
            this.PlaceBet.TabIndex = 5;
            this.PlaceBet.Text = "Bets";
            this.PlaceBet.UseVisualStyleBackColor = true;
            this.PlaceBet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(362, 49);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 17);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "name";
            // 
            // MalkeetRadioButton
            // 
            this.MalkeetRadioButton.AutoSize = true;
            this.MalkeetRadioButton.Location = new System.Drawing.Point(8, 98);
            this.MalkeetRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.MalkeetRadioButton.Name = "MalkeetRadioButton";
            this.MalkeetRadioButton.Size = new System.Drawing.Size(153, 21);
            this.MalkeetRadioButton.TabIndex = 3;
            this.MalkeetRadioButton.TabStop = true;
            this.MalkeetRadioButton.Text = "MalkeetRadioButton";
            this.MalkeetRadioButton.UseVisualStyleBackColor = true;
            this.MalkeetRadioButton.CheckedChanged += new System.EventHandler(this.MalkeetRadioButton_CheckedChanged);
            // 
            // GillRadioButton
            // 
            this.GillRadioButton.AutoSize = true;
            this.GillRadioButton.Location = new System.Drawing.Point(8, 72);
            this.GillRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.GillRadioButton.Name = "GillRadioButton";
            this.GillRadioButton.Size = new System.Drawing.Size(124, 21);
            this.GillRadioButton.TabIndex = 2;
            this.GillRadioButton.TabStop = true;
            this.GillRadioButton.Text = "GillRadioButton";
            this.GillRadioButton.UseVisualStyleBackColor = true;
            this.GillRadioButton.CheckedChanged += new System.EventHandler(this.GillRadioButton_CheckedChanged);
            // 
            // SimerRadioButton
            // 
            this.SimerRadioButton.AutoSize = true;
            this.SimerRadioButton.Location = new System.Drawing.Point(8, 47);
            this.SimerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.SimerRadioButton.Name = "SimerRadioButton";
            this.SimerRadioButton.Size = new System.Drawing.Size(140, 21);
            this.SimerRadioButton.TabIndex = 1;
            this.SimerRadioButton.TabStop = true;
            this.SimerRadioButton.Text = "SimerRadioButton";
            this.SimerRadioButton.UseVisualStyleBackColor = true;
            this.SimerRadioButton.CheckedChanged += new System.EventHandler(this.SimerRadioButton_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CycleRace.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(1010, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 507);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Cycle4PB
            // 
            this.Cycle4PB.Image = global::CycleRace.Properties.Resources.cycle4;
            this.Cycle4PB.Location = new System.Drawing.Point(11, 392);
            this.Cycle4PB.Margin = new System.Windows.Forms.Padding(2);
            this.Cycle4PB.Name = "Cycle4PB";
            this.Cycle4PB.Size = new System.Drawing.Size(156, 125);
            this.Cycle4PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cycle4PB.TabIndex = 5;
            this.Cycle4PB.TabStop = false;
            this.Cycle4PB.Click += new System.EventHandler(this.Cycle4PB_Click);
            // 
            // cycle3PB
            // 
            this.cycle3PB.Image = global::CycleRace.Properties.Resources.cycle3;
            this.cycle3PB.Location = new System.Drawing.Point(11, 269);
            this.cycle3PB.Margin = new System.Windows.Forms.Padding(2);
            this.cycle3PB.Name = "cycle3PB";
            this.cycle3PB.Size = new System.Drawing.Size(156, 119);
            this.cycle3PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cycle3PB.TabIndex = 4;
            this.cycle3PB.TabStop = false;
            // 
            // cycle2PB
            // 
            this.cycle2PB.Image = global::CycleRace.Properties.Resources.cycle2;
            this.cycle2PB.Location = new System.Drawing.Point(11, 138);
            this.cycle2PB.Margin = new System.Windows.Forms.Padding(2);
            this.cycle2PB.Name = "cycle2PB";
            this.cycle2PB.Size = new System.Drawing.Size(156, 127);
            this.cycle2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cycle2PB.TabIndex = 3;
            this.cycle2PB.TabStop = false;
            // 
            // cycle1PB
            // 
            this.cycle1PB.Image = global::CycleRace.Properties.Resources.cycle1;
            this.cycle1PB.Location = new System.Drawing.Point(12, 10);
            this.cycle1PB.Margin = new System.Windows.Forms.Padding(2);
            this.cycle1PB.Name = "cycle1PB";
            this.cycle1PB.Size = new System.Drawing.Size(155, 124);
            this.cycle1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cycle1PB.TabIndex = 2;
            this.cycle1PB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CycleRace.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CycleRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1104, 716);
            this.Controls.Add(this.Cycle4PB);
            this.Controls.Add(this.cycle3PB);
            this.Controls.Add(this.cycle2PB);
            this.Controls.Add(this.cycle1PB);
            this.Controls.Add(this.gamble);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CycleRace";
            this.Text = "CycleRace";
            this.gamble.ResumeLayout(false);
            this.gamble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GambleAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cycle4PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle3PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle2PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gamble;
        private System.Windows.Forms.PictureBox cycle1PB;
        private System.Windows.Forms.PictureBox cycle2PB;
        private System.Windows.Forms.PictureBox cycle3PB;
        private System.Windows.Forms.PictureBox Cycle4PB;
        private System.Windows.Forms.Button Go_button;
        private System.Windows.Forms.Label MalkeetBetLabel;
        private System.Windows.Forms.Label GillBetLabel;
        private System.Windows.Forms.Label SimerBetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WinnerCycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GambleAmt;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.RadioButton MalkeetRadioButton;
        private System.Windows.Forms.RadioButton GillRadioButton;
        private System.Windows.Forms.RadioButton SimerRadioButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

