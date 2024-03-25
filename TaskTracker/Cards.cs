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
    public partial class Cards : UserControl
    {
        public Cards()
        {
            InitializeComponent();
            statusBtn.Click += ControlBtnClick;
            priorityBtn.Click += ControlBtnClick;

            CardsSize = new Rectangle(Location,Size);
            creatorBtnRec= new Rectangle(creatorNameBtn.Location, creatorNameBtn.Size);
            statusBtnRec= new Rectangle(statusBtn.Location,statusBtn.Size);
            priBtnRec = new Rectangle(priorityBtn.Location,priorityBtn.Size);
            DateRec= new Rectangle(dateTimePicker.Location, dateTimePicker.Size);
            creatorLblRec= new Rectangle(NameLbl.Location, NameLbl.Size); 
            statusLblRec= new Rectangle(label1.Location, label1.Size);
            priLblRec= new Rectangle(label2.Location, label2.Size);
            dateLblRec= new Rectangle(label3.Location, label3.Size);
            TaskPBRec = new Rectangle(pictureBox1.Location,pictureBox1.Size);
            creatorPBRec = new Rectangle(pictureBox2.Location,pictureBox2.Size);
            statusPBRec = new Rectangle(pictureBox3.Location,pictureBox3.Size);
            priPBRec = new Rectangle(pictureBox4.Location,pictureBox4.Size);
            DatePBRec = new Rectangle(pictureBox5.Location,pictureBox5.Size);
            taskLblRec = new Rectangle(pictureBox1.Location,pictureBox1.Size);
            projLblRec = new Rectangle(projNameLbl.Location,projNameLbl.Size);

            TaskPanelRec = new Rectangle(TaskPanel.Location,TaskPanel.Size);
            projTitleRec = new Rectangle(projectTitlePanel.Location,projectTitlePanel.Size);
            TaskControlPanelRec = new Rectangle(taskControlPanel.Location,taskControlPanel.Size);
        }

        private Rectangle CardsSize;

        private Rectangle creatorBtnRec;
        private Rectangle statusBtnRec;
        private Rectangle priBtnRec;
        private Rectangle DateRec;
        private Rectangle creatorLblRec;
        private Rectangle statusLblRec;
        private Rectangle priLblRec;
        private Rectangle dateLblRec;
        private Rectangle creatorPBRec;
        private Rectangle statusPBRec;
        private Rectangle priPBRec;
        private Rectangle DatePBRec;
        private Rectangle TaskPBRec;
        private Rectangle projLblRec;
        private Rectangle taskLblRec;

        private Rectangle TaskPanelRec;
        private Rectangle projTitleRec;
        private Rectangle TaskControlPanelRec;

        private optionControl optionBox;
        private Button selectedStatus;


        private void Cards_Resize(object sender, EventArgs e)
        {
            resizeControl(creatorNameBtn, creatorBtnRec);
            resizeControl(statusBtn, statusBtnRec);
            resizeControl(priorityBtn, priBtnRec);
            resizeControl(dateTimePicker, DateRec);
            resizeControl(NameLbl, creatorLblRec);
            resizeControl(label1, statusLblRec);
            resizeControl(label2, priLblRec);
            resizeControl(label3, dateLblRec);
            resizeControl(projNameLbl, projLblRec);

            resizeControl(pictureBox1, TaskPBRec);
            resizeControl(pictureBox2, creatorPBRec);
            resizeControl(pictureBox3, statusPBRec);
            resizeControl(pictureBox4, priPBRec);
            resizeControl(pictureBox5, DatePBRec);

            resizeControl(TaskPanel, TaskPanelRec);
            resizeControl(projectTitlePanel, projTitleRec);
            resizeControl(taskControlPanel, TaskControlPanelRec);
        }

        private void resizeControl(Control control, Rectangle rec)
        {
            float XRatio = (float)this.Size.Width / (float)CardsSize.Width;
            float YRatio = (float)this.Size.Height / (float)CardsSize.Height;

            int newX = (int)(rec.X * XRatio);
            int newY = (int)(rec.Y * YRatio);

            int newWidth = (int)(rec.Width * XRatio);
            int newHeight = (int)(rec.Height * YRatio);

            control.Location = new System.Drawing.Point(newX, newY);
            control.Size = new System.Drawing.Size(newWidth, newHeight);
        }

        private void resizeControl(Rectangle control, Rectangle rec)
        {
            float XRatio = (float)this.Size.Width / (float)CardsSize.Width;
            float YRatio = (float)this.Size.Height / (float)CardsSize.Height;

            int newX = (int)(rec.X * XRatio);
            int newY = (int)(rec.Y * YRatio);

            int newWidth = (int)(rec.Width * XRatio);
            int newHeight = (int)(rec.Height * YRatio);

            control.Location = new System.Drawing.Point(newX, newY);
            control.Size = new System.Drawing.Size(newWidth, newHeight);
        }

        private void ControlBtnClick(Object sender, EventArgs e) {
            Button btn = (sender as Button);

            //Dispose the previous Object
            optionBox?.Dispose();

            optionBox = new optionControl();
            optionBox.Location =(PointToScreen(new Point(btn.Location.X-btn.Width/3,btn.Location.Y + optionBox.Height+btn.Height/2)));
            //Invoke the Button
            optionBox.OnControlClick?.Invoke(sender,btn.Name);
            optionBox.OnButtonClick += setStatus;
            optionBox.Show();
        }

        private void setStatus(object sender,string BtnName) {

            //Dispose OptionControl Object
            optionBox?.Dispose();

            Button btn = sender as Button;
            if (BtnName== "statusBtn") {
                statusBtn.Text = btn.Text;
                statusBtn.BackColor = btn.BackColor;
                statusBtn.Font = btn.Font;
            }
            else if (BtnName == "priorityBtn")
            {
                priorityBtn.Text = btn.Text;
                priorityBtn.BackColor = btn.BackColor;
                priorityBtn.Font = btn.Font;
            }
        }

    }
}
