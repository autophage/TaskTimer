using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimer
{
    public partial class MainView : Form
    {
        private Dictionary<DateTime, TaskEntry> log = new Dictionary<DateTime, TaskEntry>();

        public void ChangeTasks(TaskEntry task)
        {
            log.Add(DateTime.Now, task);
        }

        public MainView()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            var addTask = new AddTaskForm();
            var taskNameResult = addTask.ShowDialog(this);
            if(taskNameResult == DialogResult.OK)
            {
                var newTaskEntry = new TaskEntry(addTask.TaskName, this);
                newTaskEntry.Anchor = (AnchorStyles) ((int) AnchorStyles.Top + (int) AnchorStyles.Left + (int) AnchorStyles.Right);
                taskList.Controls.Add(newTaskEntry);
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            var logDisplay = new LogDisplay();

            StringBuilder logText = new StringBuilder();

            var aggregatedTimes = new Dictionary<TaskEntry, TimeSpan>();
            DateTime? lastLogged = null;

            foreach(var entry in log)
            {
                TimeSpan intervalSinceLastEntry = new TimeSpan();

                if(lastLogged != null)
                {
                    intervalSinceLastEntry = entry.Key.Subtract((DateTime) lastLogged);
                }

                if (aggregatedTimes.ContainsKey(entry.Value))
                {
                    aggregatedTimes[entry.Value] += intervalSinceLastEntry;
                }
                else
                {
                    aggregatedTimes.Add(entry.Value, intervalSinceLastEntry);
                }

                lastLogged = entry.Key;
            }

            foreach(var entry in aggregatedTimes)
            {
                logText.AppendLine(entry.Key.GetName() + ": " + entry.Value);
            }

            logDisplay.SetText(logText.ToString());

            logDisplay.Show();
        }
    }
}
