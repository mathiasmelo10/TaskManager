namespace TaskManager
{
    partial class TaskManagerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toDoLabel = new System.Windows.Forms.Label();
            this.InProgressLabel = new System.Windows.Forms.Label();
            this.DoneLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ToDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.NewTaskButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toDoLabel
            // 
            this.toDoLabel.AutoSize = true;
            this.toDoLabel.Location = new System.Drawing.Point(120, 58);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(37, 15);
            this.toDoLabel.TabIndex = 1;
            this.toDoLabel.Text = "To Do";
            // 
            // InProgressLabel
            // 
            this.InProgressLabel.AutoSize = true;
            this.InProgressLabel.Location = new System.Drawing.Point(296, 58);
            this.InProgressLabel.Name = "InProgressLabel";
            this.InProgressLabel.Size = new System.Drawing.Size(73, 15);
            this.InProgressLabel.TabIndex = 2;
            this.InProgressLabel.Text = "In Progress";
            // 
            // DoneLabel
            // 
            this.DoneLabel.AutoSize = true;
            this.DoneLabel.Location = new System.Drawing.Point(519, 58);
            this.DoneLabel.Name = "DoneLabel";
            this.DoneLabel.Size = new System.Drawing.Size(37, 15);
            this.DoneLabel.TabIndex = 3;
            this.DoneLabel.Text = "Done!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToDo,
            this.InProgress,
            this.Done});
            this.dataGridView1.Location = new System.Drawing.Point(3, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 285);
            this.dataGridView1.TabIndex = 4;
            // 
            // ToDo
            // 
            this.ToDo.HeaderText = "";
            this.ToDo.Name = "ToDo";
            this.ToDo.ReadOnly = true;
            this.ToDo.ToolTipText = "ToDo";
            this.ToDo.Width = 200;
            // 
            // InProgress
            // 
            this.InProgress.HeaderText = "";
            this.InProgress.Name = "InProgress";
            this.InProgress.ReadOnly = true;
            this.InProgress.Width = 200;
            // 
            // Done
            // 
            this.Done.HeaderText = "";
            this.Done.Name = "Done";
            this.Done.Width = 200;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(5, 5);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(494, 23);
            this.WelcomeLabel.TabIndex = 5;
            this.WelcomeLabel.Text = "Nice to meet you!. Don\'t procastinate and make your mental better than yesterday!" +
    "";
            this.WelcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Location = new System.Drawing.Point(505, 5);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(138, 23);
            this.NewTaskButton.TabIndex = 6;
            this.NewTaskButton.Text = "New Task !";
            this.NewTaskButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(255, 369);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save ";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(82, 369);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 399);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewTaskButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DoneLabel);
            this.Controls.Add(this.InProgressLabel);
            this.Controls.Add(this.toDoLabel);
            this.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskManagerForm";
            this.Text = "Personal Task Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label toDoLabel;
        private System.Windows.Forms.Label InProgressLabel;
        private System.Windows.Forms.Label DoneLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button NewTaskButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

