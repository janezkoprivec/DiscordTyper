namespace DiscordTyper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBtn = new System.Windows.Forms.Button();
            this.command1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interval1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.interval2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.command2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.interval3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.command3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.minimised = new System.Windows.Forms.CheckBox();
            this.time2 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.start1 = new System.Windows.Forms.Button();
            this.start2 = new System.Windows.Forms.Button();
            this.start3 = new System.Windows.Forms.Button();
            this.stop3 = new System.Windows.Forms.Button();
            this.stop2 = new System.Windows.Forms.Button();
            this.stop1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(356, 93);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start all";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // command1
            // 
            this.command1.Location = new System.Drawing.Point(87, 12);
            this.command1.Name = "command1";
            this.command1.Size = new System.Drawing.Size(153, 20);
            this.command1.TabIndex = 1;
            this.command1.Text = "rpg hunt ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interval:";
            // 
            // interval1
            // 
            this.interval1.Location = new System.Drawing.Point(310, 12);
            this.interval1.Name = "interval1";
            this.interval1.Size = new System.Drawing.Size(84, 20);
            this.interval1.TabIndex = 3;
            this.interval1.Text = "62";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interval:";
            // 
            // interval2
            // 
            this.interval2.Location = new System.Drawing.Point(310, 38);
            this.interval2.Name = "interval2";
            this.interval2.Size = new System.Drawing.Size(84, 20);
            this.interval2.TabIndex = 7;
            this.interval2.Text = "302";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Command 2: ";
            // 
            // command2
            // 
            this.command2.Location = new System.Drawing.Point(87, 38);
            this.command2.Name = "command2";
            this.command2.Size = new System.Drawing.Size(153, 20);
            this.command2.TabIndex = 5;
            this.command2.Text = "rpg chop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Interval:";
            // 
            // interval3
            // 
            this.interval3.Location = new System.Drawing.Point(310, 64);
            this.interval3.Name = "interval3";
            this.interval3.Size = new System.Drawing.Size(84, 20);
            this.interval3.TabIndex = 11;
            this.interval3.Text = "3605";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Command 3: ";
            // 
            // command3
            // 
            this.command3.Location = new System.Drawing.Point(87, 64);
            this.command3.Name = "command3";
            this.command3.Size = new System.Drawing.Size(153, 20);
            this.command3.TabIndex = 9;
            this.command3.Text = "rpg adventure";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(437, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Stop all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // minimised
            // 
            this.minimised.AutoSize = true;
            this.minimised.Checked = true;
            this.minimised.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimised.Location = new System.Drawing.Point(13, 93);
            this.minimised.Name = "minimised";
            this.minimised.Size = new System.Drawing.Size(138, 17);
            this.minimised.TabIndex = 14;
            this.minimised.Text = "Keep Discord minimised";
            this.minimised.UseVisualStyleBackColor = true;
            this.minimised.CheckedChanged += new System.EventHandler(this.minimised_CheckedChanged);
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(400, 41);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(13, 13);
            this.time2.TabIndex = 15;
            this.time2.Text = "0";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(400, 15);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(13, 13);
            this.time1.TabIndex = 16;
            this.time1.Text = "0";
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(400, 67);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(13, 13);
            this.time3.TabIndex = 17;
            this.time3.Text = "0";
            // 
            // start1
            // 
            this.start1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start1.Location = new System.Drawing.Point(432, 10);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(37, 23);
            this.start1.TabIndex = 18;
            this.start1.Text = "Start";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.start1_Click);
            // 
            // start2
            // 
            this.start2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start2.Location = new System.Drawing.Point(432, 36);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(37, 23);
            this.start2.TabIndex = 19;
            this.start2.Text = "Start";
            this.start2.UseVisualStyleBackColor = true;
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // start3
            // 
            this.start3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start3.Location = new System.Drawing.Point(432, 62);
            this.start3.Name = "start3";
            this.start3.Size = new System.Drawing.Size(37, 23);
            this.start3.TabIndex = 20;
            this.start3.Text = "Start";
            this.start3.UseVisualStyleBackColor = true;
            this.start3.Click += new System.EventHandler(this.start3_Click);
            // 
            // stop3
            // 
            this.stop3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stop3.Location = new System.Drawing.Point(475, 62);
            this.stop3.Name = "stop3";
            this.stop3.Size = new System.Drawing.Size(37, 23);
            this.stop3.TabIndex = 23;
            this.stop3.Text = "Stop";
            this.stop3.UseVisualStyleBackColor = true;
            this.stop3.Click += new System.EventHandler(this.stop3_Click);
            // 
            // stop2
            // 
            this.stop2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stop2.Location = new System.Drawing.Point(475, 36);
            this.stop2.Name = "stop2";
            this.stop2.Size = new System.Drawing.Size(37, 23);
            this.stop2.TabIndex = 22;
            this.stop2.Text = "Stop";
            this.stop2.UseVisualStyleBackColor = true;
            this.stop2.Click += new System.EventHandler(this.stop2_Click);
            // 
            // stop1
            // 
            this.stop1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stop1.Location = new System.Drawing.Point(475, 10);
            this.stop1.Name = "stop1";
            this.stop1.Size = new System.Drawing.Size(37, 23);
            this.stop1.TabIndex = 21;
            this.stop1.Text = "Stop";
            this.stop1.UseVisualStyleBackColor = true;
            this.stop1.Click += new System.EventHandler(this.stop1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 128);
            this.Controls.Add(this.stop3);
            this.Controls.Add(this.stop2);
            this.Controls.Add(this.stop1);
            this.Controls.Add(this.start3);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.minimised);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interval3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.command3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interval2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.command2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.interval1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.command1);
            this.Controls.Add(this.startBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(540, 167);
            this.MinimumSize = new System.Drawing.Size(540, 167);
            this.Name = "Form1";
            this.Text = "Discord Typer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox command1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interval1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox interval2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox command2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox interval3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox command3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox minimised;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Button start1;
        private System.Windows.Forms.Button start2;
        private System.Windows.Forms.Button start3;
        private System.Windows.Forms.Button stop3;
        private System.Windows.Forms.Button stop2;
        private System.Windows.Forms.Button stop1;
    }
}

