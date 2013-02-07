namespace WinForm
{
    partial class MainFrm
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
            this.startTaskBtn = new System.Windows.Forms.Button();
            this.taskLbl = new System.Windows.Forms.Label();
            this.taskStatuslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTaskBtn
            // 
            this.startTaskBtn.Location = new System.Drawing.Point(218, 384);
            this.startTaskBtn.Name = "startTaskBtn";
            this.startTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.startTaskBtn.TabIndex = 0;
            this.startTaskBtn.Text = "Start Task";
            this.startTaskBtn.UseVisualStyleBackColor = true;
            this.startTaskBtn.Click += new System.EventHandler(this.startTaskBtn_Click);
            // 
            // taskLbl
            // 
            this.taskLbl.AutoSize = true;
            this.taskLbl.Location = new System.Drawing.Point(53, 89);
            this.taskLbl.Name = "taskLbl";
            this.taskLbl.Size = new System.Drawing.Size(64, 13);
            this.taskLbl.TabIndex = 2;
            this.taskLbl.Text = "Task Status";
            // 
            // taskStatuslbl
            // 
            this.taskStatuslbl.AutoSize = true;
            this.taskStatuslbl.Location = new System.Drawing.Point(56, 117);
            this.taskStatuslbl.Name = "taskStatuslbl";
            this.taskStatuslbl.Size = new System.Drawing.Size(0, 13);
            this.taskStatuslbl.TabIndex = 3;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 419);
            this.Controls.Add(this.taskStatuslbl);
            this.Controls.Add(this.taskLbl);
            this.Controls.Add(this.startTaskBtn);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startTaskBtn;
        private System.Windows.Forms.Label taskLbl;
        private System.Windows.Forms.Label taskStatuslbl;
    }
}

