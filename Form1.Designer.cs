namespace AntiCheatSoftware
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.start_scan_button = new System.Windows.Forms.Button();
            this.stop_scan_button = new System.Windows.Forms.Button();
            this.path_box = new System.Windows.Forms.TextBox();
            this.file_scan_button = new System.Windows.Forms.Button();
            this.status_bar = new System.Windows.Forms.ProgressBar();
            this.start_monitor_btn = new System.Windows.Forms.Button();
            this.stop_monitor_btn = new System.Windows.Forms.Button();
            this.monitor_tmr = new System.Windows.Forms.Timer(this.components);
            this.statusBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_scan_button
            // 
            this.start_scan_button.Location = new System.Drawing.Point(89, 41);
            this.start_scan_button.Name = "start_scan_button";
            this.start_scan_button.Size = new System.Drawing.Size(94, 32);
            this.start_scan_button.TabIndex = 0;
            this.start_scan_button.Text = "Start Scan";
            this.start_scan_button.UseVisualStyleBackColor = true;
            this.start_scan_button.Click += new System.EventHandler(this.start_scan_button_Click);
            // 
            // stop_scan_button
            // 
            this.stop_scan_button.Location = new System.Drawing.Point(89, 89);
            this.stop_scan_button.Name = "stop_scan_button";
            this.stop_scan_button.Size = new System.Drawing.Size(94, 31);
            this.stop_scan_button.TabIndex = 1;
            this.stop_scan_button.Text = "Stop Scan";
            this.stop_scan_button.UseVisualStyleBackColor = true;
            // 
            // path_box
            // 
            this.path_box.Location = new System.Drawing.Point(12, 207);
            this.path_box.Name = "path_box";
            this.path_box.Size = new System.Drawing.Size(187, 20);
            this.path_box.TabIndex = 2;
            // 
            // file_scan_button
            // 
            this.file_scan_button.Location = new System.Drawing.Point(214, 202);
            this.file_scan_button.Name = "file_scan_button";
            this.file_scan_button.Size = new System.Drawing.Size(73, 29);
            this.file_scan_button.TabIndex = 3;
            this.file_scan_button.Text = "Scan File";
            this.file_scan_button.UseVisualStyleBackColor = true;
            this.file_scan_button.Click += new System.EventHandler(this.file_scan_button_Click);
            // 
            // status_bar
            // 
            this.status_bar.Location = new System.Drawing.Point(12, 136);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(275, 16);
            this.status_bar.TabIndex = 5;
            // 
            // start_monitor_btn
            // 
            this.start_monitor_btn.Location = new System.Drawing.Point(466, 41);
            this.start_monitor_btn.Name = "start_monitor_btn";
            this.start_monitor_btn.Size = new System.Drawing.Size(112, 32);
            this.start_monitor_btn.TabIndex = 6;
            this.start_monitor_btn.Text = "Start Monitor Mode";
            this.start_monitor_btn.UseVisualStyleBackColor = true;
            this.start_monitor_btn.Click += new System.EventHandler(this.start_monitor_btn_Click);
            // 
            // stop_monitor_btn
            // 
            this.stop_monitor_btn.Location = new System.Drawing.Point(466, 89);
            this.stop_monitor_btn.Name = "stop_monitor_btn";
            this.stop_monitor_btn.Size = new System.Drawing.Size(112, 31);
            this.stop_monitor_btn.TabIndex = 7;
            this.stop_monitor_btn.Text = "Stop Monitor Mode";
            this.stop_monitor_btn.UseVisualStyleBackColor = true;
            this.stop_monitor_btn.Click += new System.EventHandler(this.stop_monitor_btn_Click);
            // 
            // monitor_tmr
            // 
            this.monitor_tmr.Interval = 10;
            this.monitor_tmr.Tick += new System.EventHandler(this.monitor_tmr_Tick);
            // 
            // statusBox
            // 
            this.statusBox.AutoSize = true;
            this.statusBox.BackColor = System.Drawing.Color.Red;
            this.statusBox.Location = new System.Drawing.Point(602, 77);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(37, 13);
            this.statusBox.TabIndex = 8;
            this.statusBox.Text = "          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.stop_monitor_btn);
            this.Controls.Add(this.start_monitor_btn);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.file_scan_button);
            this.Controls.Add(this.path_box);
            this.Controls.Add(this.stop_scan_button);
            this.Controls.Add(this.start_scan_button);
            this.Name = "Form1";
            this.Text = "Anti-Cheat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_scan_button;
        private System.Windows.Forms.Button stop_scan_button;
        private System.Windows.Forms.TextBox path_box;
        private System.Windows.Forms.Button file_scan_button;
        private System.Windows.Forms.Button start_monitor_btn;
        private System.Windows.Forms.Button stop_monitor_btn;
        private System.Windows.Forms.Timer monitor_tmr;
        private System.Windows.Forms.Label statusBox;
        public System.Windows.Forms.ProgressBar status_bar;
    }
}

