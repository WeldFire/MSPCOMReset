namespace MSP_UART_Reset {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.refreshPanel = new System.Windows.Forms.Panel();
            this.progressRestart = new System.Windows.Forms.ProgressBar();
            this.timerRestart = new System.Windows.Forms.Timer(this.components);
            this.lblRestart = new System.Windows.Forms.Label();
            this.refreshPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(2, 2);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(127, 64);
            this.btnDisable.TabIndex = 0;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(135, 2);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(127, 64);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(2, 72);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(260, 47);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // refreshPanel
            // 
            this.refreshPanel.Controls.Add(this.lblRestart);
            this.refreshPanel.Controls.Add(this.progressRestart);
            this.refreshPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshPanel.Location = new System.Drawing.Point(0, 0);
            this.refreshPanel.Name = "refreshPanel";
            this.refreshPanel.Size = new System.Drawing.Size(266, 122);
            this.refreshPanel.TabIndex = 3;
            this.refreshPanel.Visible = false;
            // 
            // progressRestart
            // 
            this.progressRestart.Location = new System.Drawing.Point(12, 21);
            this.progressRestart.Name = "progressRestart";
            this.progressRestart.Size = new System.Drawing.Size(242, 23);
            this.progressRestart.Step = 2;
            this.progressRestart.TabIndex = 0;
            // 
            // timerRestart
            // 
            this.timerRestart.Tick += new System.EventHandler(this.timerRestart_Tick);
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.Location = new System.Drawing.Point(46, 69);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(172, 33);
            this.lblRestart.TabIndex = 1;
            this.lblRestart.Text = "Restarting...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 122);
            this.Controls.Add(this.refreshPanel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnDisable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "MSP UART Reset";
            this.refreshPanel.ResumeLayout(false);
            this.refreshPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel refreshPanel;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.ProgressBar progressRestart;
        private System.Windows.Forms.Timer timerRestart;
    }
}

