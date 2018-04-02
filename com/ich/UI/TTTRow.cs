using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT.com.ich.UI
{
    public partial class TTTRow : UserControl
    {
        public event Action OnStateSwitched;
        private TTTRowModel _model;

        public double TotalTime
        {
            get
            {
                return _model.SpentTime;
            }
        }

        public TTTRow()
        {
            _model = new TTTRowModel();
            _model.OnPaused += OnPaused;
            _model.OnStarted += OnStarted;
            InitializeComponent();
        }

        private void OnStarted()
        {
            State_Button.Text = "Pause";
            EndTime_Label.Text = "";
        }

        private void OnPaused()
        {
            State_Button.Text = "Start";
            EndTime_Label.Text = _model.PausedAt;
            DiffTime_Label.Text = _model.TimeDiff;
        }

        private void TTTRow_Load(object sender, EventArgs e)
        {
            CreatedAt_Label.Text = _model.CreatedAt;
        }

        private void State_Button_Click(object sender, EventArgs e)
        {
            _model.SwitchState();
            OnStateSwitched?.Invoke();
        }

        private void Delet_Button_Click(object sender, EventArgs e)
        {
            DestroyHandle();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            _model.OnPaused -= OnPaused;
            _model.OnStarted -= OnStarted;
            _model = null;
            if (OnStateSwitched != null)
            {
                foreach(var d in OnStateSwitched.GetInvocationList())
                {
                    OnStateSwitched -= (Action)d;
                }
            }
            base.OnHandleDestroyed(e);
        }

        private void Task_TextBox_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(Task_TextBox.Text);
        }
    }
}
