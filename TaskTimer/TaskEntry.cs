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
    public partial class TaskEntry : UserControl
    {
        MainView parent;

        public TaskEntry()
        {
            InitializeComponent();
        }

        public TaskEntry(string taskName, MainView parent)
        {
            InitializeComponent();
            this.Name = taskName;
            this.taskName.Text = taskName;
            this.parent = parent;
        }

        public string GetName()
        {
            return this.taskName.Text;
        }

        private void TaskName_Click(object sender, EventArgs e)
        {
            parent.ChangeTasks(this);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
