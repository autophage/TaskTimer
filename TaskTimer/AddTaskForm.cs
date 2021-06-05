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
    public partial class AddTaskForm : Form
    {
        public string TaskName { get; set; }

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.TaskName = taskNameBox.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
