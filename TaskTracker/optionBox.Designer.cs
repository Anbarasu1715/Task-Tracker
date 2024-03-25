namespace TaskTracker
{
    partial class optionBox
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.statuslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.Location = new System.Drawing.Point(40, 19);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(120, 30);
            this.Btn1.TabIndex = 9;
            this.Btn1.UseVisualStyleBackColor = false;
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.White;
            this.Btn2.Location = new System.Drawing.Point(40, 61);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(120, 30);
            this.Btn2.TabIndex = 10;
            this.Btn2.UseVisualStyleBackColor = false;
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.White;
            this.Btn3.Location = new System.Drawing.Point(40, 102);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(120, 30);
            this.Btn3.TabIndex = 11;
            this.Btn3.UseVisualStyleBackColor = false;
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.White;
            this.Btn4.Location = new System.Drawing.Point(40, 145);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(120, 30);
            this.Btn4.TabIndex = 12;
            this.Btn4.UseVisualStyleBackColor = false;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(45, 195);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.statuslbl.Size = new System.Drawing.Size(112, 28);
            this.statuslbl.TabIndex = 13;
            this.statuslbl.Text = "Set Status";
            // 
            // optionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "optionBox";
            this.Size = new System.Drawing.Size(200, 230);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.optionBox_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Label statuslbl;
    }
}
