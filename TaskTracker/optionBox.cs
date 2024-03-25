using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class optionBox : UserControl
    {
        public optionBox()
        {
            InitializeComponent();
            OnControlClick += ControlBtnClick;
        }

        private Graphics g;

        //Delegate
        public EventHandler<string> OnControlClick;


        private void ControlBtnClick(Object sender,string ButtonName) {
            if (ButtonName == "statusBtn") {
                Btn1.BackColor = Color.Green;
                Btn2.BackColor = Color.Yellow;
                Btn3.BackColor = Color.Red;
                Btn4.BackColor = Color.Gray;

                Btn1.Text = "Done";
                Btn2.Text = "Working on it";
                Btn3.Text = "Stuck";
                Btn4.Text = "Not Started";

                statuslbl.Text = "Set Status";
            }
            else if (ButtonName== "priorityBtn") {
                Btn1.BackColor = Color.Black;
                Btn2.BackColor = Color.Violet;
                Btn3.BackColor = Color.Blue;
                Btn4.BackColor = Color.LightBlue;

                Btn1.Text = "Done";
                Btn2.Text = "Working on it";
                Btn3.Text = "Stuck";
                Btn4.Text = "Not Started";

                statuslbl.Text = "Set Priority";
            }
        }

        private void optionBox_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            //Pen for DrawLine
            Pen pen = new Pen(Color.Gray,2);
            float x1 = Btn4.Width / 6.5f;
            float y1 = Btn4.Location.Y + (Btn4.Height + (Btn4.Height / 2));
            float x2 = x1+Btn4.Width + (Btn4.Width/3);
            float y2 = y1;
            g.DrawLine(pen,x1,y1,x2,y2);

        }
    }
}
