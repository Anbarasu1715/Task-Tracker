using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class optionControl : Form
    {
        public optionControl()
        {
            InitializeComponent();
            OnControlClick += ControlBtnClick;
            foreach (Control c in Controls) {
                if (c is Button) {
                    c.Click += OnControlBtnClick;
                }
            }
        }

        private Graphics g;
        private string selectedBtn;

        //Delegate
        public EventHandler<string> OnControlClick;
        public EventHandler<string> OnButtonClick;

        private void OnControlBtnClick(Object sender,EventArgs e) {
            OnButtonClick?.Invoke(sender,selectedBtn);
        }

        private void ControlBtnClick(Object sender, string ButtonName)
        {
            if (ButtonName == "statusBtn")
            {
                Btn1.BackColor = Color.FromArgb(79,200,117);
                Btn2.BackColor = Color.FromArgb(249, 172, 61);
                Btn3.BackColor = Color.FromArgb(226, 68, 92);
                Btn4.BackColor = Color.FromArgb(196,196,196);

                Btn1.Text = "Done";
                Btn2.Text = "Working on it";
                Btn3.Text = "Stuck";
                Btn4.Text = "Not Started";

                statuslbl.Text = "Set Status";
            }
            else if (ButtonName == "priorityBtn")
            {
                Btn1.BackColor = Color.FromArgb(51,51,51);
                Btn2.BackColor = Color.FromArgb(64, 24, 148);
                Btn3.BackColor = Color.FromArgb(89,89,223);
                Btn4.BackColor = Color.FromArgb(87,155,152);

                Btn1.Text = "Critical";
                Btn2.Text = "High";
                Btn3.Text = "Medium";
                Btn4.Text = "Low";

                statuslbl.Text = "Set Priority";
            }
            selectedBtn = ButtonName;
        }

        private void optionBox_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            //Pen for DrawLine
            Pen pen = new Pen(Color.Gray, 2);
            float x1 = Btn4.Width / 6.5f;
            float y1 = Btn4.Location.Y + (Btn4.Height + (Btn4.Height / 2));
            float x2 = x1 + Btn4.Width + (Btn4.Width / 3);
            float y2 = y1;
            g.DrawLine(pen, x1, y1, x2, y2);

        }

    }
}
