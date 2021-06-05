
namespace TaskTimer
{
    partial class TaskEntry
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskName = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.taskName.Location = new System.Drawing.Point(0, 0);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(205, 42);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "button1";
            this.taskName.UseVisualStyleBackColor = true;
            this.taskName.Click += new System.EventHandler(this.TaskName_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delete.Location = new System.Drawing.Point(211, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(32, 41);
            this.delete.TabIndex = 1;
            this.delete.Text = "X";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // TaskEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.taskName);
            this.Name = "TaskEntry";
            this.Size = new System.Drawing.Size(246, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taskName;
        private System.Windows.Forms.Button delete;
    }
}
