using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTT.com.ich.UI;

namespace TTT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            var row = new TTTRow();
            row.OnStateSwitched += OnTTTRowStateSwitched;
            TasksContainer.Controls.Add(row);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TasksContainer.Controls.Clear();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void TotalTime_Label_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void OnTTTRowStateSwitched()
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            double totalTime = 0;
            foreach (var c in TasksContainer.Controls)
            {
                var row = (TTTRow)c;
                totalTime += row.TotalTime;
            }
            TotalTime_Label.Text = totalTime.ToString("0.00");
        }
    }
}
