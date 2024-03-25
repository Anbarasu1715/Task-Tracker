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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            formSize = new Rectangle(Location,Size);

            foreach (Control c in Controls) {
                formConotrols.Add(new Rectangle(c.Location,c.Size));
            }
        }


        private Rectangle formSize;
        private List<Rectangle> formConotrols=new List<Rectangle>();

        private void resizeControl(Control control, Rectangle rec)
        {
            float XRatio = (float)this.Size.Width / (float)formSize.Width;
            float YRatio = (float)this.Size.Height / (float)formSize.Height;

            int newX = (int)(rec.X * XRatio);
            int newY = (int)(rec.Y * YRatio);

            int newWidth = (int)(rec.Width * XRatio);
            int newHeight = (int)(rec.Height * YRatio);

            control.Location = new System.Drawing.Point(newX, newY);
            control.Size = new System.Drawing.Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int index = 0;
            foreach (Control c in Controls) {
                resizeControl(c, formConotrols[index++]);
            }
        }
    }
}
