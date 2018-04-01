namespace TTT.com.ich.UI
{
    partial class TTTRow
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatedAt_Label = new System.Windows.Forms.Label();
            this.Task_TextBox = new System.Windows.Forms.TextBox();
            this.State_Button = new System.Windows.Forms.Button();
            this.EndTime_Label = new System.Windows.Forms.Label();
            this.DiffTime_Label = new System.Windows.Forms.Label();
            this.Delet_Button = new System.Windows.Forms.Button();
            this.BottomLine_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreatedAt_Label
            // 
            this.CreatedAt_Label.AutoSize = true;
            this.CreatedAt_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedAt_Label.Location = new System.Drawing.Point(3, 3);
            this.CreatedAt_Label.Name = "CreatedAt_Label";
            this.CreatedAt_Label.Size = new System.Drawing.Size(55, 24);
            this.CreatedAt_Label.TabIndex = 0;
            this.CreatedAt_Label.Text = "00:00";
            this.CreatedAt_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Task_TextBox
            // 
            this.Task_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Task_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Task_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Task_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task_TextBox.Location = new System.Drawing.Point(64, 6);
            this.Task_TextBox.Name = "Task_TextBox";
            this.Task_TextBox.Size = new System.Drawing.Size(357, 19);
            this.Task_TextBox.TabIndex = 1;
            this.Task_TextBox.Text = "TaskName";
            this.Task_TextBox.DoubleClick += new System.EventHandler(this.Task_TextBox_DoubleClick);
            // 
            // State_Button
            // 
            this.State_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.State_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.State_Button.Location = new System.Drawing.Point(488, 3);
            this.State_Button.Name = "State_Button";
            this.State_Button.Size = new System.Drawing.Size(75, 24);
            this.State_Button.TabIndex = 2;
            this.State_Button.Text = "Start";
            this.State_Button.UseVisualStyleBackColor = true;
            this.State_Button.Click += new System.EventHandler(this.State_Button_Click);
            // 
            // EndTime_Label
            // 
            this.EndTime_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTime_Label.AutoSize = true;
            this.EndTime_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndTime_Label.Location = new System.Drawing.Point(427, 3);
            this.EndTime_Label.Name = "EndTime_Label";
            this.EndTime_Label.Size = new System.Drawing.Size(55, 24);
            this.EndTime_Label.TabIndex = 3;
            this.EndTime_Label.Text = "00:00";
            this.EndTime_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiffTime_Label
            // 
            this.DiffTime_Label.AutoSize = true;
            this.DiffTime_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiffTime_Label.Location = new System.Drawing.Point(569, 3);
            this.DiffTime_Label.Name = "DiffTime_Label";
            this.DiffTime_Label.Size = new System.Drawing.Size(120, 24);
            this.DiffTime_Label.TabIndex = 4;
            this.DiffTime_Label.Text = "00:00:00/0.00";
            this.DiffTime_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Delet_Button
            // 
            this.Delet_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delet_Button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Delet_Button.Location = new System.Drawing.Point(715, 3);
            this.Delet_Button.Name = "Delet_Button";
            this.Delet_Button.Size = new System.Drawing.Size(38, 24);
            this.Delet_Button.TabIndex = 5;
            this.Delet_Button.Text = "X";
            this.Delet_Button.UseVisualStyleBackColor = true;
            this.Delet_Button.Click += new System.EventHandler(this.Delet_Button_Click);
            // 
            // BottomLine_Label
            // 
            this.BottomLine_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomLine_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLine_Label.Location = new System.Drawing.Point(0, 30);
            this.BottomLine_Label.Name = "BottomLine_Label";
            this.BottomLine_Label.Size = new System.Drawing.Size(756, 2);
            this.BottomLine_Label.TabIndex = 6;
            // 
            // TTTRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BottomLine_Label);
            this.Controls.Add(this.Delet_Button);
            this.Controls.Add(this.DiffTime_Label);
            this.Controls.Add(this.EndTime_Label);
            this.Controls.Add(this.State_Button);
            this.Controls.Add(this.Task_TextBox);
            this.Controls.Add(this.CreatedAt_Label);
            this.Name = "TTTRow";
            this.Size = new System.Drawing.Size(756, 32);
            this.Load += new System.EventHandler(this.TTTRow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreatedAt_Label;
        private System.Windows.Forms.TextBox Task_TextBox;
        private System.Windows.Forms.Button State_Button;
        private System.Windows.Forms.Label EndTime_Label;
        private System.Windows.Forms.Label DiffTime_Label;
        private System.Windows.Forms.Button Delet_Button;
        private System.Windows.Forms.Label BottomLine_Label;
    }
}
