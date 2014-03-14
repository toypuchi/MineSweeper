namespace MineSweeper {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btn_config = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(103, 215);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(75, 23);
            this.btn_config.TabIndex = 0;
            this.btn_config.Text = "button1";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_config);
            this.Name = "Form1";
            this.Text = "マインスイーパー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_config;
    }
}

