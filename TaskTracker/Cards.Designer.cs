namespace TaskTracker
{
    partial class Cards
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectTitlePanel = new System.Windows.Forms.Panel();
            this.projNameLbl = new System.Windows.Forms.Label();
            this.taskControlPanel = new System.Windows.Forms.Panel();
            this.priorityBtn = new System.Windows.Forms.Button();
            this.statusBtn = new System.Windows.Forms.Button();
            this.creatorNameBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker = new TaskTracker.DateAndTime();
            this.TaskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.projectTitlePanel.SuspendLayout();
            this.taskControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskPanel
            // 
            this.TaskPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TaskPanel.Controls.Add(this.pictureBox1);
            this.TaskPanel.Location = new System.Drawing.Point(7, 8);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(255, 142);
            this.TaskPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // projectTitlePanel
            // 
            this.projectTitlePanel.Controls.Add(this.projNameLbl);
            this.projectTitlePanel.Location = new System.Drawing.Point(7, 151);
            this.projectTitlePanel.Name = "projectTitlePanel";
            this.projectTitlePanel.Size = new System.Drawing.Size(255, 64);
            this.projectTitlePanel.TabIndex = 1;
            // 
            // projNameLbl
            // 
            this.projNameLbl.AutoSize = true;
            this.projNameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projNameLbl.Location = new System.Drawing.Point(11, 17);
            this.projNameLbl.Name = "projNameLbl";
            this.projNameLbl.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.projNameLbl.Size = new System.Drawing.Size(100, 28);
            this.projNameLbl.TabIndex = 0;
            this.projNameLbl.Text = "Project 1";
            // 
            // taskControlPanel
            // 
            this.taskControlPanel.Controls.Add(this.dateTimePicker);
            this.taskControlPanel.Controls.Add(this.priorityBtn);
            this.taskControlPanel.Controls.Add(this.statusBtn);
            this.taskControlPanel.Controls.Add(this.creatorNameBtn);
            this.taskControlPanel.Controls.Add(this.label3);
            this.taskControlPanel.Controls.Add(this.label2);
            this.taskControlPanel.Controls.Add(this.label1);
            this.taskControlPanel.Controls.Add(this.NameLbl);
            this.taskControlPanel.Controls.Add(this.pictureBox5);
            this.taskControlPanel.Controls.Add(this.pictureBox4);
            this.taskControlPanel.Controls.Add(this.pictureBox3);
            this.taskControlPanel.Controls.Add(this.pictureBox2);
            this.taskControlPanel.ForeColor = System.Drawing.Color.Black;
            this.taskControlPanel.Location = new System.Drawing.Point(7, 216);
            this.taskControlPanel.Name = "taskControlPanel";
            this.taskControlPanel.Size = new System.Drawing.Size(255, 176);
            this.taskControlPanel.TabIndex = 2;
            // 
            // priorityBtn
            // 
            this.priorityBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.priorityBtn.FlatAppearance.BorderSize = 0;
            this.priorityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priorityBtn.ForeColor = System.Drawing.Color.White;
            this.priorityBtn.Location = new System.Drawing.Point(128, 99);
            this.priorityBtn.Name = "priorityBtn";
            this.priorityBtn.Size = new System.Drawing.Size(120, 30);
            this.priorityBtn.TabIndex = 10;
            this.priorityBtn.UseVisualStyleBackColor = false;
            // 
            // statusBtn
            // 
            this.statusBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.statusBtn.FlatAppearance.BorderSize = 0;
            this.statusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusBtn.ForeColor = System.Drawing.Color.White;
            this.statusBtn.Location = new System.Drawing.Point(128, 63);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(120, 30);
            this.statusBtn.TabIndex = 9;
            this.statusBtn.UseVisualStyleBackColor = false;
            // 
            // creatorNameBtn
            // 
            this.creatorNameBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.creatorNameBtn.FlatAppearance.BorderSize = 0;
            this.creatorNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatorNameBtn.ForeColor = System.Drawing.Color.White;
            this.creatorNameBtn.Location = new System.Drawing.Point(128, 25);
            this.creatorNameBtn.Name = "creatorNameBtn";
            this.creatorNameBtn.Size = new System.Drawing.Size(120, 30);
            this.creatorNameBtn.TabIndex = 8;
            this.creatorNameBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Priority";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.Black;
            this.NameLbl.Location = new System.Drawing.Point(34, 30);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(63, 13);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Creator";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 141);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Resize += new System.EventHandler(this.Cards_Resize);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.BorderColor = System.Drawing.Color.Gray;
            this.dateTimePicker.BorderSize = 0;
            this.dateTimePicker.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(128, 136);
            this.dateTimePicker.MinimumSize = new System.Drawing.Size(0, 35);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 35);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.TextColor = System.Drawing.Color.White;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.taskControlPanel);
            this.Controls.Add(this.projectTitlePanel);
            this.Controls.Add(this.TaskPanel);
            this.Name = "Cards";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(270, 406);
            this.Resize += new System.EventHandler(this.Cards_Resize);
            this.TaskPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.projectTitlePanel.ResumeLayout(false);
            this.projectTitlePanel.PerformLayout();
            this.taskControlPanel.ResumeLayout(false);
            this.taskControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel projectTitlePanel;
        private System.Windows.Forms.Panel taskControlPanel;
        private System.Windows.Forms.Label projNameLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button creatorNameBtn;
        private System.Windows.Forms.Button priorityBtn;
        private System.Windows.Forms.Button statusBtn;
        private DateAndTime dateTimePicker;
    }
}
