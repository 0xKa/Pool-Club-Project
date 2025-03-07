using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_Project
{
    public partial class PlayTable : UserControl
    {

        public class TableCompletedEventArgs : EventArgs
        {
            public int TimeInSeconds { get; }
            public string TotalTime { get; }
            public decimal FeesPerHour { get; }
            public decimal TotalFees { get; }

            public TableCompletedEventArgs(int timeInSeconds, string totalTime, decimal feesPerHour, decimal totalFees)
            {
                TimeInSeconds = timeInSeconds;
                TotalTime = totalTime;
                FeesPerHour = feesPerHour;
                TotalFees = totalFees;
            }
        }
        public event EventHandler<TableCompletedEventArgs> TableCompleted;
        protected virtual void RaiseOnTableComplete(TableCompletedEventArgs e)
        {
            TableCompleted?.Invoke(this, e);
        }



        // The Category attribute tells the designer to display  
        // it in the Flash grouping.
        // The Description attribute provides a description of  
        // the property.
        private string _TableTitle = "Table";
        [Category("Pool Config"), Description("The table Name.")]
        public string TableTitle
        {
            get { return _TableTitle; }
            set
            {
                _TableTitle = value;
                groupBox1.Text = value;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                //Invalidate();

            }
        }

        private string _PlayerName = "Player";
        [Category("Pool Config"), Description("The player Name.")]
        public string PlayerName
        {
            get { return _PlayerName; }
            set
            {
                _PlayerName = value;
                lblPlayer.Text = value;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                //Invalidate();

            }
        }

        private decimal _FeesPerHour = 10;
        [Category("Pool Config"), Description("Fees per hour.")]
        public decimal FeesPerHour
        {
            get { return _FeesPerHour; }
            set
            {
                _FeesPerHour = value;
            }

        }

        public PlayTable()
        {
            InitializeComponent();
        }

        private int _Seconds = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _Seconds++;
            lblTimer.Text = TimeSpan.FromSeconds(_Seconds).ToString(@"hh\:mm\:ss");
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                lblTimer.ForeColor = Color.Green;
                timer1.Start();
            }
            else
            {
                btnStartStop.Text = "Start";
                lblTimer.ForeColor = Color.Firebrick;
                timer1.Stop();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            decimal TotalFees = ((decimal)_Seconds / 60 / 60) * FeesPerHour;

            RaiseOnTableComplete(new TableCompletedEventArgs(_Seconds, lblTimer.Text, _FeesPerHour, TotalFees));
            lblTimer.Text = "00:00:00";
            btnStartStop.Text = "Start";
            lblTimer.ForeColor = Color.White;
            _Seconds = 0;
        }

    }
}
