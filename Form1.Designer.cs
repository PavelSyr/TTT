namespace TTT
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CommandButtonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.TasksContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.TotalTime_Label = new System.Windows.Forms.Label();
            this.CommandButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTaskButton.Location = new System.Drawing.Point(3, 3);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(100, 30);
            this.AddTaskButton.TabIndex = 0;
            this.AddTaskButton.Text = "ADD";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(3, 39);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 30);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CommandButtonContainer
            // 
            this.CommandButtonContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandButtonContainer.Controls.Add(this.AddTaskButton);
            this.CommandButtonContainer.Controls.Add(this.ClearButton);
            this.CommandButtonContainer.Controls.Add(this.TotalTime_Label);
            this.CommandButtonContainer.Location = new System.Drawing.Point(783, 12);
            this.CommandButtonContainer.Name = "CommandButtonContainer";
            this.CommandButtonContainer.Size = new System.Drawing.Size(106, 404);
            this.CommandButtonContainer.TabIndex = 2;
            // 
            // TasksContainer
            // 
            this.TasksContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksContainer.Location = new System.Drawing.Point(12, 12);
            this.TasksContainer.Margin = new System.Windows.Forms.Padding(1);
            this.TasksContainer.Name = "TasksContainer";
            this.TasksContainer.Size = new System.Drawing.Size(765, 404);
            this.TasksContainer.TabIndex = 3;
            // 
            // TotalTime_Label
            // 
            this.TotalTime_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTime_Label.AutoSize = true;
            this.TotalTime_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalTime_Label.Location = new System.Drawing.Point(3, 75);
            this.TotalTime_Label.Margin = new System.Windows.Forms.Padding(3);
            this.TotalTime_Label.Name = "TotalTime_Label";
            this.TotalTime_Label.Size = new System.Drawing.Size(49, 20);
            this.TotalTime_Label.TabIndex = 2;
            this.TotalTime_Label.Text = "00:00";
            this.TotalTime_Label.Click += new System.EventHandler(this.TotalTime_Label_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(901, 428);
            this.Controls.Add(this.TasksContainer);
            this.Controls.Add(this.CommandButtonContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "TTT";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.CommandButtonContainer.ResumeLayout(false);
            this.CommandButtonContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.FlowLayoutPanel CommandButtonContainer;
        private System.Windows.Forms.FlowLayoutPanel TasksContainer;
        private System.Windows.Forms.Label TotalTime_Label;
    }
}

