namespace MineSweeper {
    partial class Config {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.groupBox_difficulty = new System.Windows.Forms.GroupBox();
            this.radioBtn_hard = new System.Windows.Forms.RadioButton();
            this.radioBtn_nomal = new System.Windows.Forms.RadioButton();
            this.radioBtn_easy = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox_difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_difficulty
            // 
            this.groupBox_difficulty.Controls.Add(this.radioBtn_hard);
            this.groupBox_difficulty.Controls.Add(this.radioBtn_nomal);
            this.groupBox_difficulty.Controls.Add(this.radioBtn_easy);
            this.groupBox_difficulty.Location = new System.Drawing.Point(12, 12);
            this.groupBox_difficulty.Name = "groupBox_difficulty";
            this.groupBox_difficulty.Size = new System.Drawing.Size(83, 92);
            this.groupBox_difficulty.TabIndex = 0;
            this.groupBox_difficulty.TabStop = false;
            this.groupBox_difficulty.Text = "難易度";
            // 
            // radioBtn_hard
            // 
            this.radioBtn_hard.AutoSize = true;
            this.radioBtn_hard.Location = new System.Drawing.Point(13, 65);
            this.radioBtn_hard.Name = "radioBtn_hard";
            this.radioBtn_hard.Size = new System.Drawing.Size(45, 16);
            this.radioBtn_hard.TabIndex = 2;
            this.radioBtn_hard.TabStop = true;
            this.radioBtn_hard.Text = "hard";
            this.radioBtn_hard.UseVisualStyleBackColor = true;
            // 
            // radioBtn_nomal
            // 
            this.radioBtn_nomal.AutoSize = true;
            this.radioBtn_nomal.Location = new System.Drawing.Point(13, 43);
            this.radioBtn_nomal.Name = "radioBtn_nomal";
            this.radioBtn_nomal.Size = new System.Drawing.Size(53, 16);
            this.radioBtn_nomal.TabIndex = 1;
            this.radioBtn_nomal.TabStop = true;
            this.radioBtn_nomal.Text = "nomal";
            this.radioBtn_nomal.UseVisualStyleBackColor = true;
            // 
            // radioBtn_easy
            // 
            this.radioBtn_easy.AutoSize = true;
            this.radioBtn_easy.Location = new System.Drawing.Point(13, 20);
            this.radioBtn_easy.Name = "radioBtn_easy";
            this.radioBtn_easy.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_easy.TabIndex = 0;
            this.radioBtn_easy.TabStop = true;
            this.radioBtn_easy.Text = "easy";
            this.radioBtn_easy.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(110, 52);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(67, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "設定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(110, 81);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(67, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "キャンセル";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 116);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.groupBox_difficulty);
            this.Name = "Config";
            this.Text = "設定";
            this.groupBox_difficulty.ResumeLayout(false);
            this.groupBox_difficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_difficulty;
        private System.Windows.Forms.RadioButton radioBtn_hard;
        private System.Windows.Forms.RadioButton radioBtn_nomal;
        private System.Windows.Forms.RadioButton radioBtn_easy;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cancel;

    }
}