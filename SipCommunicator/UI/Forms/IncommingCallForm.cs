using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sipek.Common.CallControl;

namespace SipCommunicator
{
    public partial class IncommingCallForm : Form
    {
        public event DIncomingCallNotification AnswerClick = null;
        public event DIncomingCallNotification IgnoreClick = null;

        public enum TaskbarStates
        {
            Hidden = 0,
            Appearing = 1,
            Visible = 2,
            Disappearing = 3
        }
        protected TaskbarStates taskbarState = TaskbarStates.Hidden;
        protected Timer timer = new Timer();

        private int showFadingTime = 10; //show time in ms
        private int hideFadingTime = 50; //show time in ms
        private int showingTime = 60 * 1000; //hide time in ms
        private string incomingCallNumber;
        private int sessionId;

        public int SessionId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }

        public string IncomingCallNumber
        {
            get { return incomingCallNumber; }
            set { incomingCallNumber = value; }
        }
        private string incomingCallName;

        public string IncomingCallName
        {
            get { return incomingCallName; }
            set { incomingCallName = value; }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );


        public IncommingCallForm()
        {
            InitializeComponent();
            try
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            }
            catch (Exception exc)
            { }
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - 30);
            timer.Tick += new EventHandler(timer_Tick);
        }

        public IncommingCallForm(string number, int timeout)
        {
            InitializeComponent();
            this.numberLabel.Text = number;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            switch (taskbarState)
            {
                case TaskbarStates.Hidden:
                    break;
                case TaskbarStates.Appearing:
                    if (this.Opacity < 0.99)
                    {
                        this.Opacity += 0.01;
                    }
                    else
                    {
                        timer.Stop();
                        timer.Interval = showingTime;
                        timer.Start();
                        taskbarState = TaskbarStates.Visible;
                    }
                    break;
                case TaskbarStates.Visible:
                    timer.Stop();
                    timer.Interval = hideFadingTime;
                    timer.Start();
                    taskbarState = TaskbarStates.Disappearing;
                    break;
                case TaskbarStates.Disappearing:
                    if (this.Opacity > 0.00)
                    {
                        this.Opacity -= 0.01;
                    }
                    else
                    {
                        timer.Stop();
                        this.Hide();
                        taskbarState = TaskbarStates.Hidden;
                    }
                    break;
                default:
                    break;
            }
        }

        public void ShowNotifier(int sessionId, string name, string number)
        {
            incomingCallName = name;
            incomingCallNumber = number;
            this.sessionId = sessionId;
            if (string.IsNullOrEmpty(name))
            {
                numberLabel.Text = number;
            }
            else
            {
                numberLabel.Text = name + "\n" + number;
            }

            this.Show();
            switch (taskbarState)
            {
                case TaskbarStates.Hidden:
                    timer.Stop();
                    timer.Interval = showFadingTime;
                    timer.Start();
                    taskbarState = TaskbarStates.Appearing;
                    break;
                case TaskbarStates.Appearing:
                    break;
                case TaskbarStates.Visible:
                    break;
                case TaskbarStates.Disappearing:
                    break;
                default:
                    break;
            }
        }

        private void IncommingCallForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer.Stop();
            if (AnswerClick != null)
            {
                AnswerClick(sessionId, incomingCallNumber, incomingCallName);
            }
        }

        private void ignoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer.Stop();
            if (IgnoreClick != null)
            {
                IgnoreClick(sessionId, incomingCallNumber, incomingCallName);
            }
        }

    }
}
